namespace WebApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class asdfasdf : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Referrals", new[] { "CandidateId" });
            AlterColumn("dbo.Referrals", "CandidateId", c => c.String(maxLength: 128));
            CreateIndex("dbo.Referrals", "CandidateId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Referrals", new[] { "CandidateId" });
            AlterColumn("dbo.Referrals", "CandidateId", c => c.String(nullable: false, maxLength: 128));
            CreateIndex("dbo.Referrals", "CandidateId");
        }
    }
}
