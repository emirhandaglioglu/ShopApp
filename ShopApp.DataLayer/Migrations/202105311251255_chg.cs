namespace ShopApp.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class chg : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.UserInfoes", "CreatedById");
            DropColumn("dbo.UserInfoes", "CreatedAt");
            DropColumn("dbo.UserInfoes", "UpdateById");
            DropColumn("dbo.UserInfoes", "UpdatedAt");
            DropColumn("dbo.UserInfoes", "LastLoginDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserInfoes", "LastLoginDate", c => c.DateTime());
            AddColumn("dbo.UserInfoes", "UpdatedAt", c => c.DateTime());
            AddColumn("dbo.UserInfoes", "UpdateById", c => c.Int());
            AddColumn("dbo.UserInfoes", "CreatedAt", c => c.DateTime());
            AddColumn("dbo.UserInfoes", "CreatedById", c => c.Int());
        }
    }
}
