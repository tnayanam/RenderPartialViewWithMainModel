namespace WebApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class asdfdf : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Referrals",
                c => new
                    {
                        ReferralId = c.Int(nullable: false, identity: true),
                        CandidateId = c.String(nullable: false, maxLength: 128),
                        ReferrerId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.ReferralId)
                .ForeignKey("dbo.AspNetUsers", t => t.CandidateId)
                .ForeignKey("dbo.AspNetUsers", t => t.ReferrerId, cascadeDelete: true)
                .Index(t => t.CandidateId)
                .Index(t => t.ReferrerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Referrals", "ReferrerId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Referrals", "CandidateId", "dbo.AspNetUsers");
            DropIndex("dbo.Referrals", new[] { "ReferrerId" });
            DropIndex("dbo.Referrals", new[] { "CandidateId" });
            DropTable("dbo.Referrals");
        }
    }
}
