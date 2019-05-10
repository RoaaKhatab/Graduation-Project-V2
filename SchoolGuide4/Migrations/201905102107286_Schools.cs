namespace SchoolGuide4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Schools : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Schools",
                c => new
                    {
                        Sc_id = c.Int(nullable: false, identity: true),
                        Sc_Name = c.String(nullable: false),
                        Sc_Details = c.String(nullable: false),
                        Sc_Facebook = c.String(),
                        Sc_Twitter = c.String(),
                        Sc_instagram = c.String(),
                        Sc_Image = c.String(),
                        Sc_Category = c.String(),
                        Sc_Fees_From = c.String(),
                        Sc_Fees_To = c.String(),
                        Sc_Location = c.String(nullable: false),
                        Sc_phone1 = c.Int(nullable: false),
                        Sc_phone2 = c.Int(nullable: false),
                        Sc_phone3 = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Sc_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Schools");
        }
    }
}
