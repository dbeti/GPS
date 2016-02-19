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
        private ICoordinateConverter converter;
        private IGraphDisplayProperties dp;
        private IDictionary<GraphObject, Pen> alternatePen;

        public GraphObjectPlanarDrawer(
            Graphics graphics,
            ICoordinateConverter converter,
            IGraphDisplayProperties displayProps,
            IDictionary<GraphObject, Pen> alternatePen)
        {
            this.graphics = graphics;
            this.converter = converter;
            this.alternatePen = alternatePen;
            dp = displayProps;
        }

        public void VisitGraphObject(GraphObject graphObject)
        {
            throw new ArgumentException("Cannot draw a basic GraphObject");
        }

        public void VisitNode(Node node)
        {
            int d = dp.NodeRadius;
            var p = converter.ToDisplayCoord(
                new Point(node.CoordinateX, node.CoordinateY));
            var brush = alternatePen.ContainsKey(node) ?
                alternatePen[node].Brush : dp.NodeBrush;

            graphics.DrawString(node.Name, dp.LabelFont,
                                dp.LabelBrush, p.X, p.Y - 15);
            graphics.FillEllipse(brush, p.X - d/2, p.Y - d/2, d, d);
        }

        public void VisitArc(Arc arc)
        {
            var nr = dp.NodeRadius;
            var ars = dp.ArcArrowSize/2;
            var startPoint = converter.ToDisplayCoord(arc.StartNode.Point);
            var endPoint = converter.ToDisplayCoord(arc.EndNode.Point);

            var pen = alternatePen.ContainsKey(arc) ?
                alternatePen[arc] : dp.ArcPen;
            var tmp = getOrthogonalBase(endPoint.X - startPoint.X, 
                                        endPoint.Y - startPoint.Y);
            var x = startPoint.X;
            var y = startPoint.Y;
            var c = tmp.Item1;
            var s = tmp.Item2;
            var d = tmp.Item3;
            var spx = (float)Math.Round(x + nr / 2 * c);
            var spy = (float)Math.Round(y + nr / 2 * s);
            var epx = (float)Math.Round(x + (d - nr / 2) * c);
            var epy = (float)Math.Round(y + (d - nr / 2) * s);

            var off = Math.Sqrt(3.0) * ars;
            
            graphics.DrawLine(pen, spx, spy, epx, epy);

            var epxc = (float)(epx - off * c);
            var epyc = (float)(epy - off * s);

            if (arc.Directed)
            {
                graphics.FillPolygon(pen.Brush, new PointF[] {
                    new PointF(epx, epy),
                    new PointF((float)(epxc - ars*s), (float)(epyc + ars*c)),
                    new PointF((float)(epxc + ars*s), (float)(epyc - ars*c)),
                });
            }
            var middle = new Point((startPoint.X + endPoint.X) / 2,
                                   (startPoint.Y + endPoint.Y) / 2);
            graphics.DrawString(arc.Name, dp.LabelFont,
                                dp.LabelBrush, middle);
        }

        private Tuple<double, double, double> getOrthogonalBase(double x, double y)
        {
            var d = Math.Sqrt(x * x + y * y);
            if (d == 0) return Tuple.Create(0.0, 0.0, 0.0);
            return Tuple.Create(x / d, y / d, d);
        }
    }
}
