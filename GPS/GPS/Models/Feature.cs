using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPS.Models
{
    class Feature
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public GraphObject GraphObject { get; set; }

        [ForeignKey("FeatureType")]
        public int FeatureTypeId { get; set; }
        public FeatureType FeatureType { get; set; }

        public Feature() { }
        public Feature(string name, GraphObject graphObject,
                       FeatureType featureType, string description = "")
        {
            Name = name;
            GraphObject = graphObject;
            FeatureType = featureType;
            Description = description;
        }
    }
}
