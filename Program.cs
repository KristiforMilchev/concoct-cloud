﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Rokono_Control.DataHandlers.Implementations;
using Rokono_Control.DataHandlers.Interfaces;
using Rokono_Control.Models;


namespace Rokono_Control
{
    public class Program
    {
        public static ICustomLogger Logger { get; set; }
        public static bool HasCompleate { get; set; }
        public static Config Configuration {get; set;}
        public static List<HubMappedMembers> Members { get; set; }
        public static string ServerOS { get; set; }
        public static List<ProjectBranches> ProjectBranches { get; set; }
        public static List<(string, List<(string, string, string)>)> AccountEditorPages { get; set; }
        private static List<string> ActiveUniqueIds { get; set; }

        public static void Main(string[] args)
        {
            ProjectBranches = new List<ProjectBranches>();
            Members = new List<HubMappedMembers>();
            var current = OS.GetCurrent();
            ServerOS = current;
            AccountEditorPages = new List<(string, List<(string, string, string)>)>();
            Logger = new Logger();
            ActiveUniqueIds = new List<string>();

            Logger.Info($"Server is starting at {DateTime.Now} Loading config files");
            if(!File.Exists("Configuration.json"))
                Configuration = CreateFile("Configuration.json");
            else
            {
                Configuration = ReadConfig("Configuration.json");
                switch(ServerOS)
                {
                    case "gnu":
                    Configuration.LocalRepo = "/home/ConcoctRepositories";
                    break;
                    case "win":
                    Configuration.LocalRepo = @"C:\GitRepositories";
                    break;
                }
            }
                

            CreateWebHostBuilder(args).Build().Run();
        }
        
        private static Config CreateFile(string v)
        {
            if(OS.GetCurrent() == "gnu")
                CreateLinuxDefault();
            else
                CreateWindowsDefault();

            var configuration = new Config
            {
                ShellScripts = new List<ConfigBindingData>
                {
                    new ConfigBindingData { Name = "CreateProj.sh", Path = "/home/kristifordevelopment/ShellScripts/RokonoControl/CreateProj.sh" },
                    new ConfigBindingData { Name = "AssignGroup.sh", Path = "/home/kristifordevelopment/ShellScripts/RokonoControl/AssignGroup.sh" },
                    new ConfigBindingData { Name = "GetBranches.sh", Path = "/home/kristifordevelopment/ShellScripts/RokonoControl/GetBranches.sh" },
                    new ConfigBindingData { Name = "GetGitList.sh", Path = "/home/kristifordevelopment/ShellScripts/RokonoControl/GetGitList.sh" },
                    new ConfigBindingData { Name = "GetCommitData.sh", Path = "/home/kristifordevelopment/ShellScripts/RokonoControl/GetCommitData.sh" },
                    new ConfigBindingData { Name = "GetCommitFile.sh", Path = "/home/kristifordevelopment/ShellScripts/RokonoControl/GetCommitFile.sh" },
                    new ConfigBindingData { Name = "LsFiles.sh", Path = "/home/kristifordevelopment/ShellScripts/RokonoControl/LsFiles.sh" },
                    new ConfigBindingData { Name = "GetGitList.sh", Path = "/home/kristifordevelopment/ShellScripts/RokonoControl/GetGitList.sh" },
                    new ConfigBindingData { Name = "GetCommitFile.sh", Path = "/home/kristifordevelopment/ShellScripts/RokonoControl/GetCommitFile.sh" },
                    new ConfigBindingData { Name = "GetCommitFile.sh", Path = "/home/kristifordevelopment/ShellScripts/RokonoControl" },
                },
                OS = OS.GetCurrent(),
                LocalRepo = ServerOS == "gnu" ? "/home/ConcoctRepositories" : @"C:\GitRepositories"
            };
            var config = JsonConvert.SerializeObject(configuration);
            if(!File.Exists(v))
            {
                var cFile = File.Create(v);
                cFile.Close();
                var logWriter = new System.IO.StreamWriter(v);
                logWriter.WriteLine(config);
                logWriter.Dispose();
            }
         
            return configuration;
        }

        private static void CreateWindowsDefault()
        {
            if (!Directory.Exists(@"C:\GitRepositories"))
            {
                Directory.CreateDirectory(@"C:\GitRepositories");
            }
        }

        private static void CreateLinuxDefault()
        {
            if (!Directory.Exists("/home/ConcoctRepositories"))
            {
                Directory.CreateDirectory("/home/ConcoctRepositories");
            }
        }

        private static Config ReadConfig(string path)
        {
            
            var config = File.ReadAllText(path);
            return JsonConvert.DeserializeObject<Config>(config);
        }

        public static string GetUniqueId()
        {
            var chars = "abcdefghijklmnopqrstuvwxyz0123456789";
            var random = new System.Random();
            var uniqueName = $"{Guid.NewGuid().ToString().Split('-').FirstOrDefault()}{chars[random.Next(chars.Length - 1)]}{chars[random.Next(chars.Length + 1)]}{chars[random.Next(chars.Length - 2)]}";
            if(ActiveUniqueIds.Any(x=> x == uniqueName))
                ActiveUniqueIds.Add($"{uniqueName}{chars[random.Next(chars.Length - 1)]}");
            else
                ActiveUniqueIds.Add(uniqueName);

            return uniqueName;
        }

        private static void timer1_Tick(object sender, EventArgs e)
        {
            
   
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
            .UseUrls("http://localhost:6005")
            .UseStartup<Startup>();
    }
}
