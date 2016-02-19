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

        public GraphObjectPlanarDrawer(
            Graphics graphics,
            ICoordinateConverter converter,
            IGraphDisplayProperties displayProps)
        {
            this.graphics = graphics;
            this.converter = converter;
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
            graphics.DrawString(node.Name, dp.LabelFont,
                                dp.LabelBrush, p.X, p.Y - 15);
            graphics.FillEllipse(dp.NodeBrush, p.X - d/2, p.Y - d/2, d, d);
        }

        public void VisitArc(Arc arc)
        {
            var startPoint = converter.ToDisplayCoord(arc.StartNode.Point);
            var endPoint = converter.ToDisplayCoord(arc.EndNode.Point);
            graphics.DrawLine(dp.ArcPen, startPoint, endPoint);
            var middle = new Point((startPoint.X + endPoint.X) / 2,
                                   (startPoint.Y + endPoint.Y) / 2);
            graphics.DrawString(arc.Name, dp.LabelFont,
                                dp.LabelBrush, middle);
        }
    }
}
