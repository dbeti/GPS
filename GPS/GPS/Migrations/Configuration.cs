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
            //  This method will be called after migrating to the latest version.
            context.Nodes.AddOrUpdate(new Models.Node("Label1", 100, 200),
                                      new Models.Node("Label2", 200, 300),
                                      new Models.Node("Label3", 400, 500),
                                      new Models.Node("Label4", 700, 600));
        }
    }
}
