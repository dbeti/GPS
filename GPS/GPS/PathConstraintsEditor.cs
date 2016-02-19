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
using GPS.PathFinders;

namespace GPS
{
    public partial class PathConstraintsEditor : UserControl
    {
        public GPSContext DbContext = null;

        private Node startNode = null;
        private Node endNode = null;
        private IPathFinder pathFinder = new AStarPathFinder();

        public PathConstraintsEditor()
        {
            InitializeComponent();
        }

        public class PathFoundEvenArgs : EventArgs
        {
            public IList<GraphObject> Path;
            public PathFoundEvenArgs(IList<GraphObject> path)
            {
                Path = path;
            }
        }

        public event EventHandler<PathFoundEvenArgs> PathFound;
        
        protected virtual void OnPathFound(PathFoundEvenArgs args)
        {
            var handler = PathFound;
            if (handler != null)
            {
                handler(this, args);
            }
        }

        public event EventHandler Closed;

        protected virtual void OnClosed(EventArgs args)
        {
            var handler = Closed;
            if (handler != null)
            {
                handler(this, args);
            }
        }

        public Node StartNode
        {
            get { return startNode; }
            set
            {
                startNode = value;
                updateData();
            }
        }

        public Node EndNode
        {
            get { return endNode; }
            set
            {
                endNode = value;
                updateData();
            }
        }

        private void updateData()
        {
            startNodeBox.Text = startNode != null ? startNode.Name : "None";
            endNodeBox.Text = endNode != null ? endNode.Name : "None";
            findPathButton.Enabled = startNode != null && endNode != null;
            featureSelector.Items.Clear();
            if (DbContext != null)
            {
                foreach (var featureType in DbContext.FeatureTypes)
                {
                    if (featureType.Features.Count == 0) continue;
                    var item = new ListViewItem(featureType.Name)
                    {
                        Tag = featureType
                    };
                    featureSelector.Items.Add(item);
                }
            }
        }

        private void findPathButton_Click(object sender, EventArgs e)
        {
            var constraints = from ListViewItem item in 
                                  featureSelector.CheckedItems
                              select (item.Tag as FeatureType);
            var path = pathFinder.FindPath(startNode, endNode, constraints);
            OnPathFound(new PathFoundEvenArgs(path));
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            OnClosed(EventArgs.Empty);
        }
    }
}
