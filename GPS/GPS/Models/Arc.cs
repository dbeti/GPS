using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPS.Models
{
    [Table("Arcs")]
    class Arc : GraphObject
    {
        public Node StartNode { get; set; }
        public Node EndNode { get; set; }
        public bool Directed { get; set; }

        public Arc(string name, Node startNode, Node endNode,
                   bool directed = true) : base(name)
        {
            StartNode = startNode;
            EndNode = endNode;
            Directed = directed;
        }
    }
}
