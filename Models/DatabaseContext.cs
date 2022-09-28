using System.IO;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace Rokono_Control.Models
{
    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {
        }

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var fileData = File.ReadAllText("appsettings.Development.json");
                var StartConfiguration = JsonConvert.DeserializeObject<StartupConfig>(fileData);
                optionsBuilder.UseSqlServer(StartConfiguration.ConnectionStrings.DatabaseContext);
            }
        }
        public virtual DbSet<ApiKeys> ApiKeys { get; set; }
        public virtual DbSet<AssociatedAccountNotes> AssociatedAccountNotes { get; set; }
        public virtual DbSet<AssociatedAccountProjectNotificationRights> AssociatedAccountProjectNotificationRights { get; set; }
        public virtual DbSet<AssociatedBoardWorkItems> AssociatedBoardWorkItems { get; set; }
        public virtual DbSet<AssociatedBranchCommits> AssociatedBranchCommits { get; set; }
        public virtual DbSet<AssociatedChatChannelMessages> AssociatedChatChannelMessages { get; set; }
        public virtual DbSet<AssociatedChatPersonalMessages> AssociatedChatPersonalMessages { get; set; }
        public virtual DbSet<AssociatedChatRoomRights> AssociatedChatRoomRights { get; set; }
        public virtual DbSet<AssociatedCommitFiles> AssociatedCommitFiles { get; set; }
        public virtual DbSet<AssociatedDocumentationCategoryPage> AssociatedDocumentationCategoryPage { get; set; }
        public virtual DbSet<AssociatedPageSurveyComponents> AssociatedPageSurveyComponents { get; set; }
        public virtual DbSet<AssociatedProjectApiKeys> AssociatedProjectApiKeys { get; set; }
        public virtual DbSet<AssociatedProjectBoards> AssociatedProjectBoards { get; set; }
        public virtual DbSet<AssociatedProjectBuilds> AssociatedProjectBuilds { get; set; }
        public virtual DbSet<AssociatedProjectChangelogs> AssociatedProjectChangelogs { get; set; }
        public virtual DbSet<AssociatedProjectFeedback> AssociatedProjectFeedback { get; set; }
        public virtual DbSet<AssociatedProjectIterations> AssociatedProjectIterations { get; set; }
        public virtual DbSet<AssociatedProjectMemberRights> AssociatedProjectMemberRights { get; set; }
        public virtual DbSet<AssociatedProjectMembers> AssociatedProjectMembers { get; set; }
        public virtual DbSet<AssociatedProjectNotifications> AssociatedProjectNotifications { get; set; }
        public virtual DbSet<AssociatedProjectPublicDiscussions> AssociatedProjectPublicDiscussions { get; set; }
        public virtual DbSet<AssociatedProjectPublicMessages> AssociatedProjectPublicMessages { get; set; }
        public virtual DbSet<AssociatedRepositoryBranches> AssociatedRepositoryBranches { get; set; }
        public virtual DbSet<AssociatedUserChatNotifications> AssociatedUserChatNotifications { get; set; }
        public virtual DbSet<AssociatedUserChatRights> AssociatedUserChatRights { get; set; }
        public virtual DbSet<AssociatedUserDashboardItemComponent> AssociatedUserDashboardItemComponent { get; set; }
        public virtual DbSet<AssociatedUserDashboardPremade> AssociatedUserDashboardPremade { get; set; }
        public virtual DbSet<AssociatedUserNotifications> AssociatedUserNotifications { get; set; }
        public virtual DbSet<AssociatedWorkItemChangelogs> AssociatedWorkItemChangelogs { get; set; }
        public virtual DbSet<AssociatedWorkItemFiles> AssociatedWorkItemFiles { get; set; }
        public virtual DbSet<AssociatedWorkItemMessages> AssociatedWorkItemMessages { get; set; }
        public virtual DbSet<AssociatedWrorkItemChildren> AssociatedWrorkItemChildren { get; set; }
        public virtual DbSet<Boards> Boards { get; set; }
        public virtual DbSet<Branches> Branches { get; set; }
        public virtual DbSet<Builds> Builds { get; set; }
        public virtual DbSet<Changelogs> Changelogs { get; set; }
        public virtual DbSet<ChatChannelTypes> ChatChannelTypes { get; set; }
        public virtual DbSet<ChatChannels> ChatChannels { get; set; }
        public virtual DbSet<ChatRoomRights> ChatRoomRights { get; set; }
        public virtual DbSet<ChatRooms> ChatRooms { get; set; }
        public virtual DbSet<Commits> Commits { get; set; }
        public virtual DbSet<Documentation> Documentation { get; set; }
        public virtual DbSet<DocumentationCategory> DocumentationCategory { get; set; }
        public virtual DbSet<DocumentationCategoryField> DocumentationCategoryField { get; set; }
        public virtual DbSet<Efforts> Efforts { get; set; }
        public virtual DbSet<FileTypes> FileTypes { get; set; }
        public virtual DbSet<Files> Files { get; set; }
        public virtual DbSet<NotificationRights> NotificationRights { get; set; }
        public virtual DbSet<NotificationTypes> NotificationTypes { get; set; }
        public virtual DbSet<Notifications> Notifications { get; set; }
        public virtual DbSet<PremadeWidgets> PremadeWidgets { get; set; }
        public virtual DbSet<Projects> Projects { get; set; }
        public virtual DbSet<PublicMessage> PublicMessage { get; set; }
        public virtual DbSet<PublicMessages> PublicMessages { get; set; }
        public virtual DbSet<Repository> Repository { get; set; }
        public virtual DbSet<Risks> Risks { get; set; }
        public virtual DbSet<SurveyComponent> SurveyComponent { get; set; }
        public virtual DbSet<SurveyPage> SurveyPage { get; set; }
        public virtual DbSet<Surveys> Surveys { get; set; }
        public virtual DbSet<SystemFiles> SystemFiles { get; set; }
        public virtual DbSet<TeamDashboards> TeamDashboards { get; set; }
        public virtual DbSet<Teams> Teams { get; set; }
        public virtual DbSet<UserAccounts> UserAccounts { get; set; }
        public virtual DbSet<UserDashboardItem> UserDashboardItem { get; set; }
        public virtual DbSet<UserDashboardItemComponent> UserDashboardItemComponent { get; set; }
        public virtual DbSet<UserDashboards> UserDashboards { get; set; }
        public virtual DbSet<UserNotes> UserNotes { get; set; }
        public virtual DbSet<UserQueries> UserQueries { get; set; }
        public virtual DbSet<UserRights> UserRights { get; set; }
        public virtual DbSet<ValueAreas> ValueAreas { get; set; }
        public virtual DbSet<WorkItem> WorkItem { get; set; }
        public virtual DbSet<WorkItemActivity> WorkItemActivity { get; set; }
        public virtual DbSet<WorkItemAreas> WorkItemAreas { get; set; }
        public virtual DbSet<WorkItemIterations> WorkItemIterations { get; set; }
        public virtual DbSet<WorkItemMessage> WorkItemMessage { get; set; }
        public virtual DbSet<WorkItemPriorities> WorkItemPriorities { get; set; }
        public virtual DbSet<WorkItemRealtionshipType> WorkItemRealtionshipType { get; set; }
        public virtual DbSet<WorkItemReasons> WorkItemReasons { get; set; }
        public virtual DbSet<WorkItemRelations> WorkItemRelations { get; set; }
        public virtual DbSet<WorkItemSeverities> WorkItemSeverities { get; set; }
        public virtual DbSet<WorkItemStates> WorkItemStates { get; set; }
        public virtual DbSet<WorkItemTypes> WorkItemTypes { get; set; }
 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApiKeys>(entity =>
            {
                entity.Property(e => e.FeatureName).HasMaxLength(300);
            });

            modelBuilder.Entity<AssociatedAccountNotes>(entity =>
            {
                entity.HasOne(d => d.Note)
                    .WithMany(p => p.AssociatedAccountNotes)
                    .HasForeignKey(d => d.NoteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Associate__NoteI__3118447E");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.AssociatedAccountNotes)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Associate__Proje__320C68B7");

                entity.HasOne(d => d.UserAccount)
                    .WithMany(p => p.AssociatedAccountNotes)
                    .HasForeignKey(d => d.UserAccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Associate__UserA__33008CF0");
            });

            modelBuilder.Entity<AssociatedAccountProjectNotificationRights>(entity =>
            {
                entity.HasOne(d => d.Project)
                    .WithMany(p => p.AssociatedAccountProjectNotificationRights)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK__Associate__Proje__33F4B129");

                entity.HasOne(d => d.Right)
                    .WithMany(p => p.AssociatedAccountProjectNotificationRights)
                    .HasForeignKey(d => d.RightId)
                    .HasConstraintName("FK__Associate__Right__34E8D562");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AssociatedAccountProjectNotificationRights)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Associate__UserI__35DCF99B");
            });

            modelBuilder.Entity<AssociatedBoardWorkItems>(entity =>
            {
                entity.HasOne(d => d.Board)
                    .WithMany(p => p.AssociatedBoardWorkItems)
                    .HasForeignKey(d => d.BoardId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Associate__Board__36D11DD4");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.AssociatedBoardWorkItems)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK__Associate__Proje__37C5420D");

                entity.HasOne(d => d.WorkItem)
                    .WithMany(p => p.AssociatedBoardWorkItems)
                    .HasForeignKey(d => d.WorkItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Associate__WorkI__38B96646");
            });

            modelBuilder.Entity<AssociatedBranchCommits>(entity =>
            {
                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.AssociatedBranchCommits)
                    .HasForeignKey(d => d.BranchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Associate__Branc__39AD8A7F");

                entity.HasOne(d => d.Commit)
                    .WithMany(p => p.AssociatedBranchCommits)
                    .HasForeignKey(d => d.CommitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Associate__Commi__3AA1AEB8");
            });

            modelBuilder.Entity<AssociatedChatChannelMessages>(entity =>
            {
                entity.HasOne(d => d.ChatChannel)
                    .WithMany(p => p.AssociatedChatChannelMessages)
                    .HasForeignKey(d => d.ChatChannelId)
                    .HasConstraintName("FK__Associate__ChatC__3B95D2F1");

                entity.HasOne(d => d.PublicMessage)
                    .WithMany(p => p.AssociatedChatChannelMessages)
                    .HasForeignKey(d => d.PublicMessageId)
                    .HasConstraintName("FK__Associate__Publi__3C89F72A");
            });

            modelBuilder.Entity<AssociatedChatPersonalMessages>(entity =>
            {
                entity.HasOne(d => d.Project)
                    .WithMany(p => p.AssociatedChatPersonalMessages)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK__Associate__Proje__3D7E1B63");

                entity.HasOne(d => d.PublicMessage)
                    .WithMany(p => p.AssociatedChatPersonalMessages)
                    .HasForeignKey(d => d.PublicMessageId)
                    .HasConstraintName("FK__Associate__Publi__3E723F9C");

                entity.HasOne(d => d.Reciver)
                    .WithMany(p => p.AssociatedChatPersonalMessagesReciver)
                    .HasForeignKey(d => d.ReciverId)
                    .HasConstraintName("FK__Associate__Reciv__3F6663D5");

                entity.HasOne(d => d.Sender)
                    .WithMany(p => p.AssociatedChatPersonalMessagesSender)
                    .HasForeignKey(d => d.SenderId)
                    .HasConstraintName("FK__Associate__Sende__405A880E");
            });

            modelBuilder.Entity<AssociatedChatRoomRights>(entity =>
            {
                entity.HasOne(d => d.ChatRoom)
                    .WithMany(p => p.AssociatedChatRoomRights)
                    .HasForeignKey(d => d.ChatRoomId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Associate__ChatR__414EAC47");

                entity.HasOne(d => d.Right)
                    .WithMany(p => p.AssociatedChatRoomRights)
                    .HasForeignKey(d => d.RightId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Associate__Right__4242D080");
            });

            modelBuilder.Entity<AssociatedCommitFiles>(entity =>
            {
                entity.Property(e => e.DateOfCommit).HasColumnType("datetime");

                entity.HasOne(d => d.Commit)
                    .WithMany(p => p.AssociatedCommitFiles)
                    .HasForeignKey(d => d.CommitId)
                    .HasConstraintName("FK__Associate__Commi__4336F4B9");

                entity.HasOne(d => d.File)
                    .WithMany(p => p.AssociatedCommitFiles)
                    .HasForeignKey(d => d.FileId)
                    .HasConstraintName("FK__Associate__FileI__442B18F2");
            });

            modelBuilder.Entity<AssociatedDocumentationCategoryPage>(entity =>
            {
                entity.Property(e => e.Title).HasMaxLength(400);

                entity.HasOne(d => d.CategoryFieldNavigation)
                    .WithMany(p => p.AssociatedDocumentationCategoryPage)
                    .HasForeignKey(d => d.CategoryField)
                    .HasConstraintName("FK__Associate__Categ__451F3D2B");
            });

            modelBuilder.Entity<AssociatedPageSurveyComponents>(entity =>
            {
                entity.HasOne(d => d.Component)
                    .WithMany(p => p.AssociatedPageSurveyComponents)
                    .HasForeignKey(d => d.ComponentId)
                    .HasConstraintName("FK__Associate__Compo__46136164");

                entity.HasOne(d => d.Page)
                    .WithMany(p => p.AssociatedPageSurveyComponents)
                    .HasForeignKey(d => d.PageId)
                    .HasConstraintName("FK__Associate__PageI__4707859D");
            });

            modelBuilder.Entity<AssociatedProjectApiKeys>(entity =>
            {
                entity.HasOne(d => d.Key)
                    .WithMany(p => p.AssociatedProjectApiKeys)
                    .HasForeignKey(d => d.KeyId)
                    .HasConstraintName("FK__Associate__KeyId__47FBA9D6");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.AssociatedProjectApiKeys)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK__Associate__Proje__48EFCE0F");
            });

            modelBuilder.Entity<AssociatedProjectBoards>(entity =>
            {
                entity.HasOne(d => d.Board)
                    .WithMany(p => p.AssociatedProjectBoards)
                    .HasForeignKey(d => d.BoardId)
                    .HasConstraintName("FK__Associate__Board__49E3F248");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.AssociatedProjectBoards)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK__Associate__Proje__4AD81681");
            });

            modelBuilder.Entity<AssociatedProjectBuilds>(entity =>
            {
                entity.HasOne(d => d.Build)
                    .WithMany(p => p.AssociatedProjectBuilds)
                    .HasForeignKey(d => d.BuildId)
                    .HasConstraintName("FK__Associate__Build__4BCC3ABA");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.AssociatedProjectBuilds)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK__Associate__Proje__4CC05EF3");

                entity.HasOne(d => d.Repository)
                    .WithMany(p => p.AssociatedProjectBuilds)
                    .HasForeignKey(d => d.RepositoryId)
                    .HasConstraintName("FK__Associate__Repos__4DB4832C");
            });

            modelBuilder.Entity<AssociatedProjectChangelogs>(entity =>
            {
                entity.HasOne(d => d.Log)
                    .WithMany(p => p.AssociatedProjectChangelogs)
                    .HasForeignKey(d => d.LogId)
                    .HasConstraintName("FK__Associate__LogId__4EA8A765");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.AssociatedProjectChangelogs)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK__Associate__Proje__4F9CCB9E");
            });

            modelBuilder.Entity<AssociatedProjectFeedback>(entity =>
            {
                entity.Property(e => e.Rating).HasColumnName("rating");

                entity.HasOne(d => d.Message)
                    .WithMany(p => p.AssociatedProjectFeedback)
                    .HasForeignKey(d => d.MessageId)
                    .HasConstraintName("FK__Associate__Messa__5090EFD7");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.AssociatedProjectFeedback)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK__Associate__Proje__51851410");
            });

            modelBuilder.Entity<AssociatedProjectIterations>(entity =>
            {
                entity.HasOne(d => d.Iteration)
                    .WithMany(p => p.AssociatedProjectIterations)
                    .HasForeignKey(d => d.IterationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AssociatedProjectIterations_WorkItemIterations");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.AssociatedProjectIterations)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AssociatedProjectIterations_Projects");
            });

            modelBuilder.Entity<AssociatedProjectMemberRights>(entity =>
            {
                entity.HasOne(d => d.Project)
                    .WithMany(p => p.AssociatedProjectMemberRights)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_AssociatedProjectMemberRights_Projects");

                entity.HasOne(d => d.Rights)
                    .WithMany(p => p.AssociatedProjectMemberRights)
                    .HasForeignKey(d => d.RightsId)
                    .HasConstraintName("FK_AssociatedProjectMemberRights_UserRights");

                entity.HasOne(d => d.UserAccount)
                    .WithMany(p => p.AssociatedProjectMemberRights)
                    .HasForeignKey(d => d.UserAccountId)
                    .HasConstraintName("FK_AssociatedProjectMemberRights_UserAccounts");
            });

            modelBuilder.Entity<AssociatedProjectMembers>(entity =>
            {
                entity.HasOne(d => d.Project)
                    .WithMany(p => p.AssociatedProjectMembers)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Associate__Proje__573DED66");

                entity.HasOne(d => d.Repository)
                    .WithMany(p => p.AssociatedProjectMembers)
                    .HasForeignKey(d => d.RepositoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Associate__Repos__5832119F");

                entity.HasOne(d => d.UserAccount)
                    .WithMany(p => p.AssociatedProjectMembers)
                    .HasForeignKey(d => d.UserAccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Associate__UserA__592635D8");
            });

            modelBuilder.Entity<AssociatedProjectNotifications>(entity =>
            {
                entity.HasOne(d => d.Notification)
                    .WithMany(p => p.AssociatedProjectNotifications)
                    .HasForeignKey(d => d.NotificationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Associate__Notif__5A1A5A11");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.AssociatedProjectNotifications)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Associate__Proje__5B0E7E4A");

                entity.HasOne(d => d.UserAccount)
                    .WithMany(p => p.AssociatedProjectNotifications)
                    .HasForeignKey(d => d.UserAccountId)
                    .HasConstraintName("FK__Associate__UserA__5C02A283");
            });

            modelBuilder.Entity<AssociatedProjectPublicDiscussions>(entity =>
            {
                entity.HasOne(d => d.Project)
                    .WithMany(p => p.AssociatedProjectPublicDiscussions)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK__Associate__Proje__5CF6C6BC");

                entity.HasOne(d => d.PublicMessage)
                    .WithMany(p => p.AssociatedProjectPublicDiscussions)
                    .HasForeignKey(d => d.PublicMessageId)
                    .HasConstraintName("FK__Associate__Publi__5DEAEAF5");
            });

            modelBuilder.Entity<AssociatedProjectPublicMessages>(entity =>
            {
                entity.HasOne(d => d.Message)
                    .WithMany(p => p.AssociatedProjectPublicMessages)
                    .HasForeignKey(d => d.MessageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Associate__Messa__5EDF0F2E");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.AssociatedProjectPublicMessages)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Associate__Proje__5FD33367");
            });

            modelBuilder.Entity<AssociatedRepositoryBranches>(entity =>
            {
                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.AssociatedRepositoryBranches)
                    .HasForeignKey(d => d.BranchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Associate__Branc__60C757A0");

                entity.HasOne(d => d.Repository)
                    .WithMany(p => p.AssociatedRepositoryBranches)
                    .HasForeignKey(d => d.RepositoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Associate__Repos__61BB7BD9");
            });

            modelBuilder.Entity<AssociatedUserChatNotifications>(entity =>
            {
                entity.HasOne(d => d.ChatChannel)
                    .WithMany(p => p.AssociatedUserChatNotifications)
                    .HasForeignKey(d => d.ChatChannelId)
                    .HasConstraintName("FK__Associate__ChatC__62AFA012");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.AssociatedUserChatNotifications)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK__Associate__Proje__63A3C44B");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AssociatedUserChatNotifications)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Associate__UserI__6497E884");
            });

            modelBuilder.Entity<AssociatedUserChatRights>(entity =>
            {
                entity.HasOne(d => d.Project)
                    .WithMany(p => p.AssociatedUserChatRights)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK__Associate__Proje__658C0CBD");

                entity.HasOne(d => d.Right)
                    .WithMany(p => p.AssociatedUserChatRights)
                    .HasForeignKey(d => d.RightId)
                    .HasConstraintName("FK__Associate__Right__668030F6");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AssociatedUserChatRights)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Associate__UserI__6774552F");
            });

            modelBuilder.Entity<AssociatedUserDashboardItemComponent>(entity =>
            {
                entity.HasOne(d => d.ItemNavigation)
                    .WithMany(p => p.AssociatedUserDashboardItemComponent)
                    .HasForeignKey(d => d.Item)
                    .HasConstraintName("FK__Associated__Item__695C9DA1");

                entity.HasOne(d => d.ItemComponentNavigation)
                    .WithMany(p => p.AssociatedUserDashboardItemComponent)
                    .HasForeignKey(d => d.ItemComponent)
                    .HasConstraintName("FK__Associate__ItemC__68687968");
            });

            modelBuilder.Entity<AssociatedUserDashboardPremade>(entity =>
            {
                entity.Property(e => e.CustomSettings).HasMaxLength(600);

                entity.HasOne(d => d.PremadeWidget)
                    .WithMany(p => p.AssociatedUserDashboardPremade)
                    .HasForeignKey(d => d.PremadeWidgetId)
                    .HasConstraintName("FK__Associate__Prema__6A50C1DA");

                entity.HasOne(d => d.UserDashboardNavigation)
                    .WithMany(p => p.AssociatedUserDashboardPremade)
                    .HasForeignKey(d => d.UserDashboard)
                    .HasConstraintName("FK__Associate__UserD__6B44E613");
            });

            modelBuilder.Entity<AssociatedUserNotifications>(entity =>
            {
                entity.HasOne(d => d.Notification)
                    .WithMany(p => p.AssociatedUserNotifications)
                    .HasForeignKey(d => d.NotificationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Associate__Notif__6C390A4C");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AssociatedUserNotifications)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Associate__UserI__6D2D2E85");
            });

            modelBuilder.Entity<AssociatedWorkItemChangelogs>(entity =>
            {
                entity.Property(e => e.WorkitemId).HasColumnName("workitemId");

                entity.HasOne(d => d.Log)
                    .WithMany(p => p.AssociatedWorkItemChangelogs)
                    .HasForeignKey(d => d.LogId)
                    .HasConstraintName("FK__Associate__LogId__6E2152BE");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.AssociatedWorkItemChangelogs)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK__Associate__Proje__6F1576F7");

                entity.HasOne(d => d.Workitem)
                    .WithMany(p => p.AssociatedWorkItemChangelogs)
                    .HasForeignKey(d => d.WorkitemId)
                    .HasConstraintName("FK__Associate__worki__70099B30");
            });

            modelBuilder.Entity<AssociatedWorkItemFiles>(entity =>
            {
                entity.HasOne(d => d.File)
                    .WithMany(p => p.AssociatedWorkItemFiles)
                    .HasForeignKey(d => d.FileId)
                    .HasConstraintName("FK__Associate__FileI__70FDBF69");

                entity.HasOne(d => d.WorkItem)
                    .WithMany(p => p.AssociatedWorkItemFiles)
                    .HasForeignKey(d => d.WorkItemId)
                    .HasConstraintName("FK__Associate__WorkI__71F1E3A2");
            });

            modelBuilder.Entity<AssociatedWorkItemMessages>(entity =>
            {
                entity.HasOne(d => d.Message)
                    .WithMany(p => p.AssociatedWorkItemMessages)
                    .HasForeignKey(d => d.MessageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Associate__Messa__72E607DB");

                entity.HasOne(d => d.WorkItem)
                    .WithMany(p => p.AssociatedWorkItemMessages)
                    .HasForeignKey(d => d.WorkItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Associate__WorkI__73DA2C14");
            });

            modelBuilder.Entity<AssociatedWrorkItemChildren>(entity =>
            {
                entity.HasOne(d => d.RelationTypeNavigation)
                    .WithMany(p => p.AssociatedWrorkItemChildren)
                    .HasForeignKey(d => d.RelationType)
                    .HasConstraintName("FK__Associate__Relat__74CE504D");

                entity.HasOne(d => d.WorkItemChild)
                    .WithMany(p => p.AssociatedWrorkItemChildrenWorkItemChild)
                    .HasForeignKey(d => d.WorkItemChildId)
                    .HasConstraintName("FK__Associate__WorkI__76B698BF");

                entity.HasOne(d => d.WorkItem)
                    .WithMany(p => p.AssociatedWrorkItemChildrenWorkItem)
                    .HasForeignKey(d => d.WorkItemId)
                    .HasConstraintName("FK__Associate__WorkI__75C27486");
            });

            modelBuilder.Entity<Boards>(entity =>
            {
                entity.Property(e => e.BoardName).HasMaxLength(1000);
            });

            modelBuilder.Entity<Branches>(entity =>
            {
                entity.Property(e => e.DateOfCreation).HasColumnType("datetime");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.Branches)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Branches__Projec__77AABCF8");
            });

            modelBuilder.Entity<Builds>(entity =>
            {
                entity.Property(e => e.DateOfBuild).HasColumnType("datetime");

                entity.Property(e => e.ReasonName)
                    .IsRequired()
                    .HasMaxLength(600);
            });

            modelBuilder.Entity<Changelogs>(entity =>
            {
                entity.Property(e => e.LogDetails)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ChatChannelTypes>(entity =>
            {
                entity.Property(e => e.TypeName).HasMaxLength(500);
            });

            modelBuilder.Entity<ChatChannels>(entity =>
            {
                entity.Property(e => e.ChannelName).HasMaxLength(300);

                entity.HasOne(d => d.ChannelTypeNavigation)
                    .WithMany(p => p.ChatChannels)
                    .HasForeignKey(d => d.ChannelType)
                    .HasConstraintName("FK__ChatChann__Chann__789EE131");

                entity.HasOne(d => d.ChatRoomNavigation)
                    .WithMany(p => p.ChatChannels)
                    .HasForeignKey(d => d.ChatRoom)
                    .HasConstraintName("FK__ChatChann__ChatR__7993056A");
            });

            modelBuilder.Entity<ChatRoomRights>(entity =>
            {
                entity.Property(e => e.Background).HasMaxLength(500);

                entity.Property(e => e.Foreground).HasMaxLength(500);

                entity.Property(e => e.RightName)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.HasOne(d => d.Poject)
                    .WithMany(p => p.ChatRoomRights)
                    .HasForeignKey(d => d.PojectId)
                    .HasConstraintName("FK__ChatRoomR__Pojec__7A8729A3");
            });

            modelBuilder.Entity<ChatRooms>(entity =>
            {
                entity.Property(e => e.RoomName).HasMaxLength(300);

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ChatRooms)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK__ChatRooms__Proje__7B7B4DDC");
            });

            modelBuilder.Entity<Commits>(entity =>
            {
                entity.Property(e => e.CommitData).IsRequired();

                entity.Property(e => e.DateOfCommit).HasColumnType("datetime");
            });

            modelBuilder.Entity<Documentation>(entity =>
            {
                entity.Property(e => e.Apikey).HasColumnName("APIKey");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.Documentation)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK__Documenta__Proje__7C6F7215");
            });

            modelBuilder.Entity<DocumentationCategory>(entity =>
            {
                entity.Property(e => e.CategoryName).HasMaxLength(300);

                entity.HasOne(d => d.Documentation)
                    .WithMany(p => p.DocumentationCategory)
                    .HasForeignKey(d => d.DocumentationId)
                    .HasConstraintName("FK__Documenta__Docum__7D63964E");
            });

            modelBuilder.Entity<DocumentationCategoryField>(entity =>
            {
                entity.Property(e => e.PageName).HasMaxLength(300);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.DocumentationCategoryField)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK__Documenta__Categ__7E57BA87");
            });

            modelBuilder.Entity<Efforts>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.EffortName).HasMaxLength(300);
            });

            modelBuilder.Entity<FileTypes>(entity =>
            {
                entity.Property(e => e.TypeName).HasMaxLength(300);
            });

            modelBuilder.Entity<Files>(entity =>
            {
                entity.Property(e => e.DateOfFile).HasColumnType("datetime");
            });

            modelBuilder.Entity<NotificationRights>(entity =>
            {
                entity.Property(e => e.BugReportNenabled).HasColumnName("BugReportNEnabled");

                entity.Property(e => e.ChanegelogNenabled).HasColumnName("ChanegelogNEnabled");

                entity.Property(e => e.ChatChannelNenabled).HasColumnName("ChatChannelNEnabled");

                entity.Property(e => e.CreateWorkItemNenabled).HasColumnName("CreateWorkItemNEnabled");

                entity.Property(e => e.FeedbackNenabled).HasColumnName("FeedbackNEnabled");

                entity.Property(e => e.PersonalMessageNenabled).HasColumnName("PersonalMessageNEnabled");

                entity.Property(e => e.PublicDiscussionMnenabled).HasColumnName("PublicDiscussionMNEnabled");

                entity.Property(e => e.UpdateWorkItemNenabled).HasColumnName("UpdateWorkItemNEnabled");
            });

            modelBuilder.Entity<NotificationTypes>(entity =>
            {
                entity.Property(e => e.Icon).HasMaxLength(300);

                entity.Property(e => e.NotificationType).IsRequired();
            });

            modelBuilder.Entity<Notifications>(entity =>
            {
                entity.Property(e => e.Content).IsRequired();

                entity.Property(e => e.DateOfMessage).HasColumnType("datetime");

                entity.HasOne(d => d.NotificationTypeNavigation)
                    .WithMany(p => p.Notifications)
                    .HasForeignKey(d => d.NotificationType)
                    .HasConstraintName("FK__Notificat__Notif__7F4BDEC0");
            });

            modelBuilder.Entity<PremadeWidgets>(entity =>
            {
                entity.Property(e => e.ControlDescription).HasMaxLength(500);

                entity.Property(e => e.ControlName).HasMaxLength(200);

                entity.Property(e => e.Settings).HasMaxLength(600);

                entity.Property(e => e.ViewComponentName).HasMaxLength(200);
            });

            modelBuilder.Entity<Projects>(entity =>
            {
                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.HasOne(d => d.Repository)
                    .WithMany(p => p.Projects)
                    .HasForeignKey(d => d.RepositoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Projects__Reposi__004002F9");
            });

            modelBuilder.Entity<PublicMessage>(entity =>
            {
                entity.Property(e => e.Content).IsRequired();

                entity.Property(e => e.DateOfMessage).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<PublicMessages>(entity =>
            {
                entity.Property(e => e.DateOfMessage).HasColumnType("datetime");

                entity.Property(e => e.SenderName)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Repository>(entity =>
            {
                entity.Property(e => e.FolderPath).IsRequired();
            });

            modelBuilder.Entity<Risks>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.RiskName).HasMaxLength(300);
            });

            modelBuilder.Entity<SurveyComponent>(entity =>
            {
                entity.Property(e => e.PlatformName).HasMaxLength(200);
            });

            modelBuilder.Entity<SurveyPage>(entity =>
            {
                entity.Property(e => e.PageName).HasMaxLength(10);

                entity.HasOne(d => d.Survey)
                    .WithMany(p => p.SurveyPage)
                    .HasForeignKey(d => d.SurveyId)
                    .HasConstraintName("FK__SurveyPag__Surve__01342732");
            });

            modelBuilder.Entity<Surveys>(entity =>
            {
                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(800);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.Surveys)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK__Surveys__Created__02284B6B");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.Surveys)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK__Surveys__Project__031C6FA4");
            });

            modelBuilder.Entity<SystemFiles>(entity =>
            {
                entity.Property(e => e.DateOfMessage).HasColumnType("datetime");

                entity.Property(e => e.SenderName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.FileTypeNavigation)
                    .WithMany(p => p.SystemFiles)
                    .HasForeignKey(d => d.FileType)
                    .HasConstraintName("FK__SystemFil__FileT__041093DD");
            });

            modelBuilder.Entity<TeamDashboards>(entity =>
            {
                entity.Property(e => e.DateOfCreation).HasColumnType("datetime");

                entity.HasOne(d => d.Team)
                    .WithMany(p => p.TeamDashboards)
                    .HasForeignKey(d => d.TeamId)
                    .HasConstraintName("FK__TeamDashb__TeamI__0504B816");
            });

            modelBuilder.Entity<Teams>(entity =>
            {
                entity.Property(e => e.DateOfCreation).HasColumnType("datetime");
            });

            modelBuilder.Entity<UserAccounts>(entity =>
            {
                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.FirstName).HasMaxLength(400);

                entity.Property(e => e.GitUsername).HasMaxLength(300);

                entity.Property(e => e.LastName).HasMaxLength(400);

                entity.Property(e => e.Password).IsRequired();
            });

            modelBuilder.Entity<UserDashboardItem>(entity =>
            {
                entity.Property(e => e.ItemName).HasMaxLength(200);

                entity.HasOne(d => d.UserDashboardNavigation)
                    .WithMany(p => p.UserDashboardItem)
                    .HasForeignKey(d => d.UserDashboard)
                    .HasConstraintName("FK__UserDashb__UserD__05F8DC4F");
            });

            modelBuilder.Entity<UserDashboardItemComponent>(entity =>
            {
                entity.Property(e => e.ComponentName).HasMaxLength(200);
            });

            modelBuilder.Entity<UserDashboards>(entity =>
            {
                entity.Property(e => e.DateOfDashboard).HasColumnType("datetime");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.UserDashboards)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK__UserDashb__Proje__06ED0088");

                entity.HasOne(d => d.TeamDashboardNavigation)
                    .WithMany(p => p.UserDashboards)
                    .HasForeignKey(d => d.TeamDashboard)
                    .HasConstraintName("FK__UserDashb__TeamD__07E124C1");
            });

            modelBuilder.Entity<UserNotes>(entity =>
            {
                entity.Property(e => e.DateOfMessage).HasColumnType("datetime");

                entity.Property(e => e.NoteBackground)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.NoteForeground)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<UserQueries>(entity =>
            {
                entity.Property(e => e.DateOfQuery).HasColumnType("datetime");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserQueries)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__UserQueri__UserI__08D548FA");
            });

            modelBuilder.Entity<ValueAreas>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ValueAreaName).HasMaxLength(300);
            });

            modelBuilder.Entity<WorkItem>(entity =>
            {
                entity.Property(e => e.ClosedDated).HasColumnType("datetime");

                entity.Property(e => e.Compleated).HasMaxLength(300);

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.ItemPriority).HasColumnName("itemPriority");

                entity.Property(e => e.OriginEstitame).HasMaxLength(300);

                entity.Property(e => e.Remaining).HasMaxLength(300);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.StoryPoints).HasMaxLength(400);

                entity.HasOne(d => d.ActivityNavigation)
                    .WithMany(p => p.WorkItem)
                    .HasForeignKey(d => d.Activity)
                    .HasConstraintName("FK__WorkItem__Activi__09C96D33");

                entity.HasOne(d => d.Area)
                    .WithMany(p => p.WorkItem)
                    .HasForeignKey(d => d.AreaId)
                    .HasConstraintName("FK__WorkItem__AreaId__0ABD916C");

                entity.HasOne(d => d.AssignedAccountNavigation)
                    .WithMany(p => p.WorkItem)
                    .HasForeignKey(d => d.AssignedAccount)
                    .HasConstraintName("FK__WorkItem__Assign__0BB1B5A5");

                entity.HasOne(d => d.IterationNavigation)
                    .WithMany(p => p.WorkItem)
                    .HasForeignKey(d => d.Iteration)
                    .HasConstraintName("FK__WorkItem__Iterat__0CA5D9DE");

                entity.HasOne(d => d.Priority)
                    .WithMany(p => p.WorkItem)
                    .HasForeignKey(d => d.PriorityId)
                    .HasConstraintName("FK__WorkItem__Priori__0D99FE17");

                entity.HasOne(d => d.ReasonNavigation)
                    .WithMany(p => p.WorkItem)
                    .HasForeignKey(d => d.ReasonId)
                    .HasConstraintName("FK__WorkItem__Reason__0E8E2250");

                entity.HasOne(d => d.Relation)
                    .WithMany(p => p.WorkItem)
                    .HasForeignKey(d => d.RelationId)
                    .HasConstraintName("FK__WorkItem__Relati__0F824689");

                entity.HasOne(d => d.Risk)
                    .WithMany(p => p.WorkItem)
                    .HasForeignKey(d => d.RiskId)
                    .HasConstraintName("FK__WorkItem__RiskId__10766AC2");

                entity.HasOne(d => d.SeverityNavigation)
                    .WithMany(p => p.WorkItem)
                    .HasForeignKey(d => d.Severity)
                    .HasConstraintName("FK__WorkItem__Severi__116A8EFB");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.WorkItem)
                    .HasForeignKey(d => d.StateId)
                    .HasConstraintName("FK__WorkItem__StateI__125EB334");

                entity.HasOne(d => d.ValueArea)
                    .WithMany(p => p.WorkItem)
                    .HasForeignKey(d => d.ValueAreaId)
                    .HasConstraintName("FK__WorkItem__ValueA__1352D76D");

                entity.HasOne(d => d.WorkItemType)
                    .WithMany(p => p.WorkItem)
                    .HasForeignKey(d => d.WorkItemTypeId)
                    .HasConstraintName("FK__WorkItem__WorkIt__1446FBA6");
            });

            modelBuilder.Entity<WorkItemActivity>(entity =>
            {
                entity.Property(e => e.ActivityName)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<WorkItemAreas>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AreaName)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<WorkItemIterations>(entity =>
            {
                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.IterationName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<WorkItemMessage>(entity =>
            {
                entity.Property(e => e.DateOfMessage).HasColumnType("datetime");

                entity.HasOne(d => d.Sender)
                    .WithMany(p => p.WorkItemMessage)
                    .HasForeignKey(d => d.SenderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__WorkItemM__Sende__153B1FDF");
            });

            modelBuilder.Entity<WorkItemPriorities>(entity =>
            {
                entity.Property(e => e.PriorityName)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<WorkItemRealtionshipType>(entity =>
            {
                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<WorkItemReasons>(entity =>
            {
                entity.Property(e => e.ReasonName)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<WorkItemRelations>(entity =>
            {
                entity.Property(e => e.RelationName).HasMaxLength(300);
            });

            modelBuilder.Entity<WorkItemSeverities>(entity =>
            {
                entity.Property(e => e.SeverityName)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<WorkItemStates>(entity =>
            {
                entity.Property(e => e.StateName).HasMaxLength(300);
            });

            modelBuilder.Entity<WorkItemTypes>(entity =>
            {
                entity.Property(e => e.Icon).HasMaxLength(600);

                entity.Property(e => e.TypeName).HasMaxLength(300);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
