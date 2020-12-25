namespace AngularChatApp20SepNight.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mi20sepnight : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Message",
                c => new
                    {
                        MessageId = c.Int(nullable: false, identity: true),
                        MessageText = c.String(),
                        MessageDate = c.DateTime(nullable: false),
                        UserName = c.String(),
                        ConnectionId = c.String(),
                    })
                .PrimaryKey(t => t.MessageId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Message");
        }
    }
}
