namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addPateAndPizza : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pizzas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nom = c.String(maxLength: 20),
                        Pate_Id = c.Int(),
                        Personne_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pates", t => t.Pate_Id)
                .ForeignKey("dbo.Personnes", t => t.Personne_Id)
                .Index(t => t.Pate_Id)
                .Index(t => t.Personne_Id);
            
            CreateTable(
                "dbo.Ingredients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nom = c.String(),
                        Pizza_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pizzas", t => t.Pizza_Id)
                .Index(t => t.Pizza_Id);
            
            AddColumn("dbo.Pates", "Personne_Id", c => c.Int());
            CreateIndex("dbo.Pates", "Personne_Id");
            AddForeignKey("dbo.Pates", "Personne_Id", "dbo.Personnes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pizzas", "Personne_Id", "dbo.Personnes");
            DropForeignKey("dbo.Pizzas", "Pate_Id", "dbo.Pates");
            DropForeignKey("dbo.Ingredients", "Pizza_Id", "dbo.Pizzas");
            DropForeignKey("dbo.Pates", "Personne_Id", "dbo.Personnes");
            DropIndex("dbo.Ingredients", new[] { "Pizza_Id" });
            DropIndex("dbo.Pizzas", new[] { "Personne_Id" });
            DropIndex("dbo.Pizzas", new[] { "Pate_Id" });
            DropIndex("dbo.Pates", new[] { "Personne_Id" });
            DropColumn("dbo.Pates", "Personne_Id");
            DropTable("dbo.Ingredients");
            DropTable("dbo.Pizzas");
        }
    }
}
