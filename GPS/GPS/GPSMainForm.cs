using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GPS.Models;
using GPS.GraphDisplay;
using GPS.PathFinders;

namespace GPS
{
    public partial class GPSMainForm : Form
    {
        public interface ITool
        {
            void ProcessGraphClick(GraphMouseEventArgs args);
            void Cleanup();
        }

        private static GPSContext db = new GPSContext();
        private Node selected;
        private ITool currentTool;

        public GPSMainForm()
        {
            InitializeComponent();

            graphContainer.DbContext = db;
            graphObjectEditor.DbContext = db;

            toolShowInformation.Tag = new InfoTool(this);
            toolAddNode.Tag = new NodeTool(this);
            toolConnectNodes.Tag = new ArcTool(this);
            toolShortestPath.Tag = new ShortestPathTool(this);

            toolShowInformation.Checked = true;
            currentTool = toolShowInformation.Tag as ITool;
        }

        private void toolAction_Click(object sender, EventArgs e)
        {
            var btn = sender as ToolStripButton;
            currentTool.Cleanup();
            currentTool = btn.Tag as ITool;
            foreach(var tool in graphTools.Items)
            {
                (tool as ToolStripButton).Checked = false;
            }
            btn.Checked = true;
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            if (selected == null)
            {
                MessageBox.Show("Please select start node", "Warning");
            }
            else {
                Node node = new Node();

                try
                {
                    node.CoordinateX = Convert.ToInt32(this.NodeCoordinateX.Text);
                    node.CoordinateY = Convert.ToInt32(this.NodeCoordinateY.Text);
                    node.Name = NodeName.Text;
                    db.Nodes.Add(node);
                    db.Arcs.Add(new Arc("TestArc", selected, node));
                    db.SaveChanges();
                    selected = null;
                    graphContainer.Refresh();
                }
                catch (FormatException formatException)
                {
                    MessageBox.Show("Please enter valid values for coordinates", "Warning");
                }
            }

        }

        private void graphContainer_GraphMouseClick(
            object sender, 
            GraphMouseEventArgs e)
        {
            currentTool.ProcessGraphClick(e);
        }

        private void graphObjectEditor_GraphObjectUpdated(object sender, 
            GraphObjectEditor.GraphObjectEventArgs e)
        {
            graphContainer.Refresh();
            if (e.ChangeKind == GraphObjectEditor.ChangeKind.Canceled ||
                e.ChangeKind == GraphObjectEditor.ChangeKind.Deleted)
            {
                infoSplit.Panel2Collapsed = true;
            }
        }

        protected class InfoTool : ITool
        {
            private GPSMainForm parent;
            private GraphObject selected = null;

            public InfoTool(GPSMainForm parent)
            {
                this.parent = parent;
            }

            public void ProcessGraphClick(GraphMouseEventArgs args)
            {
                parent.graphContainer.RemoveHighlight(selected);
                selected = args.GraphObject;
                if (selected != null)
                {
                    parent.infoSplit.Panel2Collapsed = false;
                    parent.graphObjectEditor.GraphObject = selected;
                    parent.graphContainer.HighlightAsSelected(selected);
                }
                else
                {
                    parent.infoSplit.Panel2Collapsed = true;
                }
            }

            public void Cleanup()
            {
                parent.graphContainer.RemoveHighlight(selected);
                selected = null;
            }
        }

        protected class NodeTool : ITool
        {
            private GPSMainForm parent;

            public NodeTool(GPSMainForm parent)
            {
                this.parent = parent;
            }

            public void ProcessGraphClick(GraphMouseEventArgs args)
            {
                if (args.GraphObject == null)
                {
                    parent.graphObjectEditor.GraphObject = new Node()
                    {
                        Point = args.Location
                    };
                    parent.graphObjectEditor.Editing = true;
                    parent.infoSplit.Panel2Collapsed = false;
                }
                else if (args.GraphObject is Node)
                {
                    parent.selected = args.GraphObject as Node;
                }
            }

            public void Cleanup()
            {
                parent.graphObjectEditor.Editing = false;
                parent.infoSplit.Panel2Collapsed = true;
            }
        }
        
        protected abstract class TwoNodeSelectTool : ITool
        {
            protected GPSMainForm parent;
            protected Node firstNode = null;
            protected Node secondNode = null;

            public TwoNodeSelectTool(GPSMainForm parent)
            {
                this.parent = parent;
            }

            public virtual void ProcessGraphClick(GraphMouseEventArgs args)
            {
                if (args.GraphObject is Node)
                {
                    if (firstNode == null || secondNode != null)
                    {
                        Cleanup();
                        firstNode = args.GraphObject as Node;
                        parent.graphContainer.HighlightAsSelected(firstNode);
                    }
                    else
                    {
                        secondNode = args.GraphObject as Node;
                        parent.graphContainer.HighlightAsSelected(secondNode);
                        onTwoNodesSelected(firstNode, secondNode);
                    }
                }
                else
                {
                    Cleanup();
                }
            }

            public virtual void Cleanup()
            {
                parent.graphContainer.RemoveHighlight(firstNode);
                parent.graphContainer.RemoveHighlight(secondNode);
                firstNode = null;
                secondNode = null;
            }

            protected abstract void onTwoNodesSelected(
                Node firstNode,
                Node secondNode);
        }

        protected class ArcTool : TwoNodeSelectTool
        {

            public ArcTool(GPSMainForm parent) : base(parent) { }

            protected override void onTwoNodesSelected(
                Node firstNode,
                Node secondNode)
            {
                parent.graphObjectEditor.GraphObject = new Arc()
                {
                    StartNode = firstNode,
                    EndNode = secondNode
                };
                parent.graphObjectEditor.Editing = true;
                parent.infoSplit.Panel2Collapsed = false;
            }

            public override void Cleanup()
            {
                base.Cleanup();
                parent.graphObjectEditor.Editing = false;
                parent.infoSplit.Panel2Collapsed = true;
            }
        }

        protected class ShortestPathTool : TwoNodeSelectTool
        {
            private IPathFinder pathFinder;
            private IList<GraphObject> path;

            public ShortestPathTool(GPSMainForm parent) : base(parent)
            {
                pathFinder = new AStarPathFinder();
            }

            protected override void onTwoNodesSelected(
                Node firstNode,
                Node secondNode)
            {
                path = pathFinder.FindPath(firstNode, secondNode, 
                    Enumerable.Empty<FeatureType>());
                if (path != null)
                {
                    foreach (var obj in path)
                    {
                        parent.graphContainer.HighlightAsSelected(obj);
                    }
                }
            }

            public override void Cleanup()
            {
                base.Cleanup();
                if (path != null)
                {
                    foreach (var obj in path)
                    {
                        parent.graphContainer.RemoveHighlight(obj);
                    }
                }
            }
        }
    }
}
