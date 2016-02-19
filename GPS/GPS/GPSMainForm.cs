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

namespace GPS
{
    public partial class GPSMainForm : Form
    {
        private static GPSContext db = new GPSContext();
        private Node selected;
        private ToolStripButton[] ActionTools;
        private int selectedAction;

        public GPSMainForm()
        {
            InitializeComponent();
            graphContainer.DbContext = db;
            ActionTools = new ToolStripButton[]
            {
                toolDefaultAction,
                toolAddNode,
                toolConnectNodes,
                toolShowInformation
            };
            foreach (ToolStripButton btn in ActionTools)
            {
                btn.Click += toolAction_Click;
            }
            toolDefaultAction.Checked = true;
            graphObjectEditor.DbContext = db;
        }

        private void toolAction_Click(object sender, EventArgs e)
        {
            foreach (var item in ActionTools.Select((btn, index) => new { index, btn }))
            {
                if (item.btn == (ToolStripButton)sender)
                {
                    item.btn.Checked = true;
                    selectedAction = item.index;
                }
                else
                {
                    item.btn.Checked = false;
                }
            }
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

        private void graphContainer_GraphMouseClick(object sender, 
            GraphDisplay.PlanarGraphDrawer.GraphMouseEventArgs e)
        {
            switch (selectedAction)
            {
                case 1:
                    if (e.GraphObject == null)
                    {
                        graphObjectEditor.GraphObject = new Node()
                        {
                            Point = e.Location
                        };
                        graphObjectEditor.Editing = true;
                        infoSplit.Panel2Collapsed = false;
                    }
                    else if (e.GraphObject is Node)
                    {
                        selected = e.GraphObject as Node;
                    }

                    break;
                case 2:
                    if (e.GraphObject is Node)
                    {
                        if (selected != null)
                        {
                            graphObjectEditor.GraphObject = new Arc()
                            {
                                StartNode = selected,
                                EndNode = e.GraphObject as Node
                            };
                            graphObjectEditor.Editing = true;
                            infoSplit.Panel2Collapsed = false;
                            selected = null;
                        }
                        else
                        {
                            selected = e.GraphObject as Node;
                        }
                    }
                    else
                    {
                        selected = null;
                    }
                    break;
                case 3:
                    if (e.GraphObject != null)
                    {
                        infoSplit.Panel2Collapsed = false;
                        graphObjectEditor.GraphObject = e.GraphObject;
                    }
                    else
                    {
                        infoSplit.Panel2Collapsed = true;
                    }
                    break;
            }
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

    }
}
