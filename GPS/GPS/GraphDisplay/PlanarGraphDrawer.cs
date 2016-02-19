using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using GPS.Models;

namespace GPS.GraphDisplay
{
    public partial class PlanarGraphDrawer : UserControl
    {
        private ICoordinateConverter coordConverter =
            new SimpleCoordinateConverter();
        private IGraphDisplayProperties displayProps =
            new UglyGraphDisplayProperties();

        public class GraphMouseEventArgs : MouseEventArgs
        {
            public GraphObject GraphObject;
            public GraphMouseEventArgs(MouseEventArgs args, GraphObject obj)
                : base(args.Button, args.Clicks, args.X, args.Y, args.Delta)
            {
                GraphObject = obj;
            }
        }

        public event EventHandler<GraphMouseEventArgs> GraphMouseClick;

        protected virtual void OnGraphMouseClick(GraphMouseEventArgs args)
        {
            var handler = GraphMouseClick;
            if (handler != null)
            {
                handler(this, args);
            }
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            var dbPoint = coordConverter.ToDbCoord(new Point(e.X, e.Y));
            e = new MouseEventArgs(e.Button, e.Clicks, dbPoint.X, 
                                   dbPoint.Y, e.Delta);
            OnGraphMouseClick(new GraphMouseEventArgs(
                e, objectClicked(dbPoint)));
        }

        public GPSContext DbContext { get; set; }

        public PlanarGraphDrawer()
        {
            InitializeComponent();
            BackColor = displayProps.Background;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (DbContext != null)
            {
                var drawer = new GraphObjectPlanarDrawer(
                    e.Graphics, coordConverter, displayProps);
                foreach (var graphObject in DbContext.GraphObjects.ToList())
                {
                    graphObject.Accept(drawer);
                }
            }
        }

        private GraphObject objectClicked(Point p)
        {
            foreach (var graphObject in DbContext.GraphObjects.ToList())
            {
                Point location = graphObject.Location();
                if (p.X >= location.X - 5 && p.X <= location.X + 5)
                {
                    if (p.Y >= location.Y - 5 && p.Y <= location.Y + 5)
                    {
                        return graphObject;
                    }
                }
            }
            return null;
        }
    }
}
