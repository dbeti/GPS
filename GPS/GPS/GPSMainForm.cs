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

            public void Cleanup() { }
        }

        protected class ArcTool : ITool
        {
            private GPSMainForm parent;
            private Node startNode = null;
            private Node endNode = null;

            public ArcTool(GPSMainForm parent)
            {
                this.parent = parent;
            }

            public void ProcessGraphClick(GraphMouseEventArgs args)
            {
                if (args.GraphObject is Node)
                {
                    if (startNode == null || endNode != null)
                    {
                        Cleanup();
                        startNode = args.GraphObject as Node;
                        parent.graphContainer.HighlightAsSelected(startNode);
                    }
                    else
                    {
                        endNode = args.GraphObject as Node;
                        parent.graphObjectEditor.GraphObject = new Arc()
                        {
                            StartNode = startNode,
                            EndNode = endNode
                        };
                        parent.graphObjectEditor.Editing = true;
                        parent.infoSplit.Panel2Collapsed = false;
                        parent.graphContainer.HighlightAsSelected(endNode);
                    }
                }
                else
                {
                    Cleanup();
                }
            }

            public void Cleanup()
            {
                parent.graphContainer.RemoveHighlight(startNode);
                parent.graphContainer.RemoveHighlight(endNode);
                startNode = null;
                endNode = null;
                parent.graphObjectEditor.Editing = false;
                parent.infoSplit.Panel2Collapsed = true;
            }
        }
    }
}
