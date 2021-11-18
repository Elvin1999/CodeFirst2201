namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAge : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Authors", "Age", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Authors", "Age");
        }
    }
}
