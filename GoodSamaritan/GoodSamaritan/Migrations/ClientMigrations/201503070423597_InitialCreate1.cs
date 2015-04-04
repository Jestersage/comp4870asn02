namespace GoodSamaritan.Migrations.ClientMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Clients", "ReferralContact_ReferralContactId", "dbo.ReferralContacts");
            DropIndex("dbo.Clients", new[] { "ReferralContact_ReferralContactId" });
            RenameColumn(table: "dbo.Clients", name: "ReferralContact_ReferralContactId", newName: "ReferralContactId");
            AddColumn("dbo.Clients", "Gender", c => c.String());
            AlterColumn("dbo.Clients", "ReferralContactId", c => c.Int(nullable: false));
            CreateIndex("dbo.Clients", "ReferralContactId");
            AddForeignKey("dbo.Clients", "ReferralContactId", "dbo.ReferralContacts", "ReferralContactId", cascadeDelete: true);
            DropColumn("dbo.Clients", "Source");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Clients", "Source", c => c.String());
            DropForeignKey("dbo.Clients", "ReferralContactId", "dbo.ReferralContacts");
            DropIndex("dbo.Clients", new[] { "ReferralContactId" });
            AlterColumn("dbo.Clients", "ReferralContactId", c => c.Int());
            DropColumn("dbo.Clients", "Gender");
            RenameColumn(table: "dbo.Clients", name: "ReferralContactId", newName: "ReferralContact_ReferralContactId");
            CreateIndex("dbo.Clients", "ReferralContact_ReferralContactId");
            AddForeignKey("dbo.Clients", "ReferralContact_ReferralContactId", "dbo.ReferralContacts", "ReferralContactId");
        }
    }
}
