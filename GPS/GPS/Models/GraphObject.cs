using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPS.Models
{
    class GraphObject
    {
        public int GraphObjectId { get; set; }
        public string Name { get; set; }
        public virtual List<Feature> Features { get; set; }

        public GraphObject() { }
        public GraphObject(string name)
        {
            Name = name;
        }
    }
}
