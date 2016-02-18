namespace GPS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFeatureType : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Nodes");
            CreateTable(
                "dbo.GraphObjects",
                c => new
                    {
                        GraphObjectId = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.GraphObjectId);
            
            CreateTable(
                "dbo.Features",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 4000),
                        Description = c.String(maxLength: 4000),
                        FeatureTypeId = c.Int(nullable: false),
                        GraphObject_GraphObjectId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.FeatureTypes", t => t.FeatureTypeId, cascadeDelete: true)
                .ForeignKey("dbo.GraphObjects", t => t.GraphObject_GraphObjectId)
                .Index(t => t.FeatureTypeId)
                .Index(t => t.GraphObject_GraphObjectId);
            
            CreateTable(
                "dbo.FeatureTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Arcs",
                c => new
                    {
                        GraphObjectId = c.Int(nullable: false),
                        EndNode_GraphObjectId = c.Int(),
                        StartNode_GraphObjectId = c.Int(),
                        Directed = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.GraphObjectId)
                .ForeignKey("dbo.GraphObjects", t => t.GraphObjectId)
                .ForeignKey("dbo.Nodes", t => t.EndNode_GraphObjectId)
                .ForeignKey("dbo.Nodes", t => t.StartNode_GraphObjectId)
                .Index(t => t.GraphObjectId)
                .Index(t => t.EndNode_GraphObjectId)
                .Index(t => t.StartNode_GraphObjectId);
            
            AddColumn("dbo.Nodes", "GraphObjectId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Nodes", "GraphObjectId");
            CreateIndex("dbo.Nodes", "GraphObjectId");
            AddForeignKey("dbo.Nodes", "GraphObjectId", "dbo.GraphObjects", "GraphObjectId");
            DropColumn("dbo.Nodes", "Id");
            DropColumn("dbo.Nodes", "Label");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Nodes", "Label", c => c.String(maxLength: 4000));
            AddColumn("dbo.Nodes", "Id", c => c.Int(nullable: false, identity: true));
            DropForeignKey("dbo.Nodes", "GraphObjectId", "dbo.GraphObjects");
            DropForeignKey("dbo.Arcs", "StartNode_GraphObjectId", "dbo.Nodes");
            DropForeignKey("dbo.Arcs", "EndNode_GraphObjectId", "dbo.Nodes");
            DropForeignKey("dbo.Arcs", "GraphObjectId", "dbo.GraphObjects");
            DropForeignKey("dbo.Features", "GraphObject_GraphObjectId", "dbo.GraphObjects");
            DropForeignKey("dbo.Features", "FeatureTypeId", "dbo.FeatureTypes");
            DropIndex("dbo.Nodes", new[] { "GraphObjectId" });
            DropIndex("dbo.Arcs", new[] { "StartNode_GraphObjectId" });
            DropIndex("dbo.Arcs", new[] { "EndNode_GraphObjectId" });
            DropIndex("dbo.Arcs", new[] { "GraphObjectId" });
            DropIndex("dbo.Features", new[] { "GraphObject_GraphObjectId" });
            DropIndex("dbo.Features", new[] { "FeatureTypeId" });
            DropPrimaryKey("dbo.Nodes");
            DropColumn("dbo.Nodes", "GraphObjectId");
            DropTable("dbo.Arcs");
            DropTable("dbo.FeatureTypes");
            DropTable("dbo.Features");
            DropTable("dbo.GraphObjects");
            AddPrimaryKey("dbo.Nodes", "Id");
        }
    }
}
