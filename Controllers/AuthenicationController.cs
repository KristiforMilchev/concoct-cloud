namespace Rokono_Control.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Security.Claims;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Authentication;
    using Microsoft.AspNetCore.Authentication.Cookies;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Rokono_Control.Models;
    using Microsoft.Extensions.Configuration;
    using Platform.DatabaseHandlers.Contexts;

    public class AuthenicationController : Controller
    {
        DatabaseContext Context;
        IConfiguration Configuration;

        public AuthenicationController(DatabaseContext context,IConfiguration config)
        {
            Context = context;
            Configuration = config;
        }
        public IActionResult Index()
        {
            return View();
        }

     
        [HttpGet]
        public List<OutgoingUserAccounts> GetUsers()
        {
            var result = new List<OutgoingUserAccounts>();
            using (var context = new UsersContext(Context,Configuration))
            {
                result = context.GetUserAccounts();
            }
            return result;
        }
        [HttpGet]
        public List<OutgoingUserAccounts> GetAvtiveUsers()
        {
            var result = new List<OutgoingUserAccounts>();

            return result;
        }
        [HttpGet]
        public List<WorkItemIterations> GetNewProjectIterationns()
        {
            var result = new List<WorkItemIterations>();
            result = new List<WorkItemIterations>
            {
                new WorkItemIterations{IterationName = "Iteration 1"},
                new WorkItemIterations{IterationName = "Iteration 2"},
                new WorkItemIterations{IterationName = "Iteration 3"},
            };
            return result;
        }
        [HttpGet]
        public List<OutgoingAccountManagment> GetManagmentUsers(int projectId)
        {
            var result = new List<OutgoingAccountManagment>();
            using (var context = new UsersContext(Context,Configuration))
            {
                result = context.GetOutgoingManagmentAccounts(projectId);
            }
            return result;
        }

        [HttpPost]
        public async Task<JsonResult> Login([FromBody] IncomingLoginRequest request)
        {
            var jsonrResult = Json("False");
            // var result = Json("failed"); 
            using (var context = new UsersContext(Context,Configuration))
            {
                var result = context.LoginUser(request);
                if (result != null)
                {
                    jsonrResult = Json("Success");
                    var identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme, ClaimTypes.Name, ClaimTypes.Role);
                    identity.AddClaim(new Claim(ClaimTypes.NameIdentifier, result.Email));
                    identity.AddClaim(new Claim(ClaimTypes.Actor, result.Id.ToString()));
                    identity.AddClaim(new Claim(ClaimTypes.Email, result.ProjectRights.Value.ToString()));
                    identity.AddClaim(new Claim(ClaimTypes.Role, "User"));


                    // identity.AddClaim(new Claim(ClaimTypes.Name,  result.FirstName));
                    // identity.AddClaim(new Claim(ClaimTypes.Role, "User"));
                    // identity.AddClaim(new Claim(ClaimTypes.SerialNumber, result.SubscriptionId.ToString()));

                    var principal = new ClaimsPrincipal(identity);

                    var authProperties = new AuthenticationProperties
                    {
                        AllowRefresh = true,
                        ExpiresUtc = DateTimeOffset.Now.AddDays(1),
                        IsPersistent = true,
                    };

                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(principal), authProperties);
                    return jsonrResult;
                    //   return new OutgoingJsonData { Data = JsonConvert.SerializeObject(result) };
                }




            }
            return jsonrResult;
        }
        
        [HttpPost]
        public bool UserAccountUpdated([FromBody]  IncomingUserAccountUpdate projectRuleData)
        {
            using (var context = new UsersContext(Context, Configuration))
            {
                context.UpdateUserAccount(projectRuleData);
            }
            return true;
        }
        [HttpPost]
        public string AddNewUserAccount([FromBody] IncomingNewUserAccount user)
        {
            var accountId = string.Empty;
            using (var context = new UsersContext(Context,Configuration))
            {
                var cAccountId = context.AddUserAccount(user);
                accountId = cAccountId.ToString();
            }
            return accountId;

        }
    }
}