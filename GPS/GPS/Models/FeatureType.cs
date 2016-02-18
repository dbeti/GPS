using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPS.Models
{
    class FeatureType
    {
        public int Id { get; set; }
        public string Name { get; set; }
         
        public virtual List<Feature> Features { get; set; }

        public FeatureType() { }
        public FeatureType(string name)
        {
            Name = name;
        }
    }
}
