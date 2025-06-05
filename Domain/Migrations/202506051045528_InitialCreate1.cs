namespace Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UDbTableRoles",
                c => new
                    {
                        UDbTable_Id = c.Int(nullable: false),
                        Role_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.UDbTable_Id, t.Role_Id })
                .ForeignKey("dbo.UDbTables", t => t.UDbTable_Id, cascadeDelete: true)
                .ForeignKey("dbo.Roles", t => t.Role_Id, cascadeDelete: true)
                .Index(t => t.UDbTable_Id)
                .Index(t => t.Role_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UDbTableRoles", "Role_Id", "dbo.Roles");
            DropForeignKey("dbo.UDbTableRoles", "UDbTable_Id", "dbo.UDbTables");
            DropIndex("dbo.UDbTableRoles", new[] { "Role_Id" });
            DropIndex("dbo.UDbTableRoles", new[] { "UDbTable_Id" });
            DropTable("dbo.UDbTableRoles");
            DropTable("dbo.Roles");
        }
    }
}
