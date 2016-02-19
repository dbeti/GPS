using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Common;

namespace GPS.Models
{
    public class GPSContext : DbContext
    {
        public GPSContext() : base("GPSConnectionString") { }
        public GPSContext(DbConnection connection) 
            : base(connection, true) { }
        public DbSet<GraphObject> GraphObjects { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<FeatureType> FeatureTypes { get; set; }
        public DbSet<Node> Nodes { get; set; }
        public DbSet<Arc> Arcs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Arc>()
                .HasRequired(x => x.StartNode)
                .WithMany(x => x.OutArcs)
                .WillCascadeOnDelete(true);
            modelBuilder.Entity<Arc>()
                .HasRequired(x => x.EndNode)
                .WithMany(x => x.InArcs)
                .WillCascadeOnDelete(true);
            modelBuilder.Entity<Feature>()
                .HasRequired(x => x.GraphObject)
                .WithMany(x => x.Features)
                .WillCascadeOnDelete(true);
            modelBuilder.Entity<Feature>()
                .HasRequired(x => x.FeatureType)
                .WithMany(x => x.Features)
                .WillCascadeOnDelete(true);
        }
    }
}
