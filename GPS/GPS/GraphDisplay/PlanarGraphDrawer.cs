﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
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

        private IDictionary<GraphObject, Pen> specialHighlight
            = new Dictionary<GraphObject, Pen>();

        private GraphObject[] highlightedPath = null;
        private GraphObject[] highlightedConstraints = null;
        public GPSContext DbContext;

        public event EventHandler<GraphMouseEventArgs> GraphMouseClick;

        public PlanarGraphDrawer()
        {
            InitializeComponent();
            BackColor = displayProps.Background;
        }

        public void HighlightAsSelected(GraphObject graphObject)
        {
            if (graphObject != null)
            {
                specialHighlight[graphObject] = displayProps.SelectedPen;
                Refresh();
            }
        }

        public void RemoveHighlight(GraphObject graphObject)
        {
            if (graphObject != null &&
                specialHighlight.ContainsKey(graphObject))
            {
                specialHighlight.Remove(graphObject);
                Refresh();
            }
        }
        public void HighlightConstraints(HashSet<GraphObject> constraints)
        {
            if (highlightedConstraints != null)
            {
                foreach (var obj in highlightedConstraints)
                {
                    if (specialHighlight.ContainsKey(obj))
                    {
                        specialHighlight.Remove(obj);
                    }
                }
            }
            highlightedConstraints = constraints != null ? constraints.ToArray() : null;
            if (highlightedConstraints != null)
            {
                foreach (var obj in highlightedConstraints)
                {
                    specialHighlight[obj] = displayProps.HighlightPen;
                }
            }
            Refresh();
        }
        public void HighlightPath(IEnumerable<GraphObject> path)
        {
            if (highlightedPath != null)
            {
                foreach (var obj in highlightedPath)
                {
                    if (specialHighlight.ContainsKey(obj))
                    {
                        specialHighlight.Remove(obj);
                    }
                }
            }
            highlightedPath = path != null ? path.ToArray() : null;
            if (highlightedPath != null)
            {
                foreach (var obj in highlightedPath)
                {
                    specialHighlight[obj] = displayProps.PathPen;
                }
            }
            Refresh();
        }

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


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            if (DbContext != null)
            {
                var drawer = new GraphObjectPlanarDrawer(
                    e.Graphics, coordConverter, displayProps,
                    specialHighlight);
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
