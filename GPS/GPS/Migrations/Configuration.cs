namespace GPS.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<GPS.Models.GPSContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(GPS.Models.GPSContext context)
        {
            Models.Node node1 = new Models.Node("Node1", 100, 200);
            Models.Node node2 = new Models.Node("Node2", 200, 300);
            Models.Node node3 = new Models.Node("Node3", 400, 500);
            Models.Node node4 = new Models.Node("Node4", 700, 600);

            context.Nodes.AddOrUpdate(node1, node2, node3, node4);

            context.Arcs.AddOrUpdate(new Models.Arc("Arc1", node1, node2),
                                     new Models.Arc("Arc2", node2, node3),
                                     new Models.Arc("Arc3", node3, node4));
        }
    }
}
