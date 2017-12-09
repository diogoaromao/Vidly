namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'9d8412f4-41a6-485a-9387-aaec8afcfe54', N'guest@vidly.com', 0, N'AB2BJ13g47pvO+yRaO3muPyLYVyQLRaznsw5MsZjbzemiGxdTCaWMhlFIUU9fB/Pxg==', N'26aa2886-d974-4e6c-b6cd-37c7888a1d48', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'db5b258d-f8aa-400d-9595-b5cb04423c5e', N'admin@vidly.com', 0, N'AFa3HutZIufCWrIAOLjK7/Rde4dEJyaTXlIEMHPBqgDsa5dMsQFhDSZNJtKb5OaLtg==', N'ad0835be-5a0b-4215-b706-df7341416377', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'f62717a5-7d49-4cee-a087-dd3808a7a198', N'diogoaromao@gmail.com', 0, N'AMp0JTeYS/iyd8Rt6+bQCgE2AIMoxvnsNlYrTfbaIkZGXfHxt7FAZ05gQvO/oUxwng==', N'f97561e9-cc10-4d15-a139-8f00f1ad3a2f', NULL, 0, 0, NULL, 1, 0, N'diogoaromao@gmail.com')
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'd9239f53-f5f1-4f83-a61b-a30c9ccc9efa', N'CanManageMovies')
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'db5b258d-f8aa-400d-9595-b5cb04423c5e', N'd9239f53-f5f1-4f83-a61b-a30c9ccc9efa')
            ");
        }
        
        public override void Down()
        {
        }
    }
}
