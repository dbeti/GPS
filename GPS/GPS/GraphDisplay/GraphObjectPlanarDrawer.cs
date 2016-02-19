using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GPS.Models;
using System.Drawing;

namespace GPS.GraphDisplay
{
    class GraphObjectPlanarDrawer : IGraphObjectVisitor
    {
        private Graphics graphics;

        public GraphObjectPlanarDrawer(Graphics graphics)
        {
            this.graphics = graphics;
        }

        public void VisitGraphObject(GraphObject graphObject)
        {
            throw new ArgumentException("Cannot draw a basic GraphObject");
        }

        public void VisitNode(Node node)
        {
            int d = Properties.Settings.Default.Diameter;
            graphics.DrawString(node.Name, new Font("Arial", 8), Brushes.Black, 
                                new PointF(node.CoordinateX, node.CoordinateY - 15));
            graphics.DrawEllipse(Pens.Red, node.CoordinateX, node.CoordinateY, d, d);
        }

        public void VisitArc(Arc arc)
        {
            int d = Properties.Settings.Default.Diameter;
            graphics.DrawLine(Pens.Red,
                              arc.StartNode.CoordinateX + d / 2,
                              arc.StartNode.CoordinateY + d / 2,
                              arc.EndNode.CoordinateX + d / 2,
                              arc.EndNode.CoordinateY + d / 2);
            var p = new PointF(
                (arc.StartNode.CoordinateX + arc.EndNode.CoordinateX) / 2,
                (arc.StartNode.CoordinateY + arc.EndNode.CoordinateY) / 2);
            graphics.DrawString(arc.Name, new Font("Arial", 8),
                                Brushes.Black, p);
        }
    }
}
