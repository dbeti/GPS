using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GPS.Models
{
    [Table("Nodes")]
    class Node : GraphObject
    {
        public int CoordinateX { get; set; }
        public int CoordinateY { get; set; }

        [InverseProperty("StartNode")]
        public virtual List<Arc> OutArcs { get; set; }
        [InverseProperty("EndNode")]
        public virtual List<Arc> InArcs { get; set; }

        public Node() { }
        public Node(string name, int coordinateX, int coordinateY) 
            : base(name)
        {
            CoordinateX = coordinateX;
            CoordinateY = coordinateY;
        }

        [NotMapped]
        public Point Point
        {
            get { return new Point(CoordinateX, CoordinateY); }
            set { CoordinateX = value.X; CoordinateY = value.Y; }
        }
    }
}
