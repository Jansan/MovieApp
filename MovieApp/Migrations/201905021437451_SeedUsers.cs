namespace MovieApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'132bfe63-8b71-4b70-927b-8726cc8fa969', N'admin@movieapp.com', 0, N'AKF+4I9HkJ06msnZB3MSw/acdxOxGh7bcTcgJdoXDIuAcQJGHHuyu65w1Xr1KWUu5Q==', N'0a2b01f1-01e2-4c18-b0a0-d932d9b2f947', NULL, 0, 0, NULL, 1, 0, N'admin@movieapp.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'24f20673-1b6a-47c2-af8f-438a7f7b3da5', N'guest@movieapp.com', 0, N'AETMyniDke5ZjmIY4/FL6kY0W7hozOalRZPtazyxhAQwrVFqWeF0mBYpv+MZMW7bvQ==', N'f9ca9480-3b5b-4a3b-b14f-d27cada21c6d', NULL, 0, 0, NULL, 1, 0, N'guest@movieapp.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'5cf2c208-21cb-4ef9-973d-3326807a8d88', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'132bfe63-8b71-4b70-927b-8726cc8fa969', N'5cf2c208-21cb-4ef9-973d-3326807a8d88')


");
        }

        public override void Down()
        {
        }
    }
}
