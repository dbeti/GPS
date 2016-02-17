using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace GPS.Models
{
    class GPSContext : DbContext
    {
        public GPSContext() : base("GPSConnectionString") { }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Node> Nodes { get; set; }
        public DbSet<Arc> Arcs { get; set; }
    }
}
