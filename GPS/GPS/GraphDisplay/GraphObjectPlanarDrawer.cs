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
            var startPoint = converter.ToDisplayCoord(arc.StartNode.Point);
            var endPoint = converter.ToDisplayCoord(arc.EndNode.Point);
            var pen = alternatePen.ContainsKey(arc) ?
                alternatePen[arc] : dp.ArcPen;
            graphics.DrawLine(pen, startPoint, endPoint);
            var middle = new Point((startPoint.X + endPoint.X) / 2,
                                   (startPoint.Y + endPoint.Y) / 2);
            graphics.DrawString(arc.Name, dp.LabelFont,
                                dp.LabelBrush, middle);
        }
    }
}
