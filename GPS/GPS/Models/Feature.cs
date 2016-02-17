using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        public Feature(string name, GraphObject graphObject,
                       string description = "")
        {
            Name = name;
            GraphObject = graphObject;
            Description = description;
        }
    }
}
