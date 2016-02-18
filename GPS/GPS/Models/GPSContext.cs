using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Common;

namespace GPS.Models
{
    class GPSContext : DbContext
    {
        public GPSContext() : base("GPSConnectionString") { }
        public GPSContext(DbConnection connection) 
            : base(connection, true) { }
        public virtual DbSet<Feature> Features { get; set; }
        public virtual DbSet<FeatureType> FeatureTypes { get; set; }
        public virtual DbSet<Node> Nodes { get; set; }
        public virtual DbSet<Arc> Arcs { get; set; }
    }
}
