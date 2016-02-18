namespace GPS.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    using Models;

    internal sealed class Configuration : DbMigrationsConfiguration<global::GPS.Models.GPSContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(global::GPS.Models.GPSContext context)
        {
            //  This method will be called after migrating to the latest version.
            context.Features.RemoveRange(context.Features);
            context.FeatureTypes.RemoveRange(context.FeatureTypes);
            context.Arcs.RemoveRange(context.Arcs);
            context.Nodes.RemoveRange(context.Nodes);

            Node[] nodes =
            {
                new Node("Left Up",    100, 100),
                new Node("Right Up",   200, 100),
                new Node("Left Down",  100, 200),
                new Node("Right Down", 200, 200),
                new Node("Center",     150, 150),
                new Node("Around we go", 300, 150),
            };

            Arc[] arcs =
            {
                new Arc("LU-RU", nodes[0], nodes[1]),
                new Arc("LU-LD", nodes[0], nodes[2]),
                new Arc("LU-C", nodes[0], nodes[4], false),
                new Arc("RD-C", nodes[3], nodes[4]),
                new Arc("RU-RD", nodes[1], nodes[3]),
                new Arc("LD-RD", nodes[2], nodes[3]),
                new Arc("RG1", nodes[1], nodes[5]),
                new Arc("RG2", nodes[5], nodes[3])
            };

            FeatureType[] ftypes =
            {
                new FeatureType("Store"),
                new FeatureType("Diner")
            };

            Feature[] features =
            {
                new Feature("Wallmart", nodes[4], ftypes[0]),
                new Feature("Mo's", nodes[5], ftypes[1])
            };

            context.Nodes.AddOrUpdate(nodes);
            context.Arcs.AddOrUpdate(arcs);
            context.FeatureTypes.AddOrUpdate(ftypes);
            context.Features.AddOrUpdate(features);
        }
    }
}
