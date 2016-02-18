using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Windows.Forms;
using System.Drawing;

namespace GPS.Models
{
    [Table("Nodes")]
    public class Node : GraphObject
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

        public override void Draw(PaintEventArgs e)
        {
            int d = Properties.Settings.Default.Diameter;
            e.Graphics.DrawString(Name, new Font("Arial", 8), Brushes.Black, new PointF(CoordinateX, CoordinateY - 15));
            e.Graphics.DrawEllipse(Pens.Red, CoordinateX, CoordinateY, d, d);
        }

        public override Point Location()
        {
            return new Point(CoordinateX, CoordinateY);
        }

        [NotMapped]
        public Point Point
        {
            get { return new Point(CoordinateX, CoordinateY); }
            set { CoordinateX = value.X; CoordinateY = value.Y; }
        }
    }
}
