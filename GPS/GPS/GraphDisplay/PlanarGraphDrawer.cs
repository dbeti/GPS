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
            OnGraphMouseClick(new GraphMouseEventArgs(e, objectClicked(e)));
        }

        public GPSContext DbContext { get; set; }

        public PlanarGraphDrawer()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (DbContext != null)
            {
                var drawer = new GraphObjectPlanarDrawer(e.Graphics);
                foreach (GraphObject graphObject in DbContext.GraphObjects.ToList())
                {
                    graphObject.Accept(drawer);
                }
            }
        }

        private GraphObject objectClicked(MouseEventArgs e)
        {
            foreach (var graphObject in DbContext.GraphObjects.ToList())
            {
                Point location = graphObject.Location();
                if (e.X >= location.X && e.X <= location.X + 10)
                {
                    if (e.Y >= location.Y && e.Y <= location.Y + 10)
                    {
                        return graphObject;
                    }
                }
            }
            return null;
        }
    }
}
