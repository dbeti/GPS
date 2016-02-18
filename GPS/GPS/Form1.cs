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
    public partial class Form1 : Form
    {
        private static GPSContext db = new GPSContext();
        private Node selected;
        private ToolStripButton[] ActionTools;
        private int selectedAction;

        public Form1()
        {
            InitializeComponent();
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
                    panel2.Refresh();
                }
                catch (FormatException formatException)
                {
                    MessageBox.Show("Please enter valid values for coordinates", "Warning");
                }
            }


        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            foreach (GraphObject graphObject in db.GraphObjects.ToList())
            {
                graphObject.Draw(e);
            }
        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            Node node;
            switch (selectedAction)
            {
                case 1:
                    node = clicked(e);
                    if (node == null)
                    {
                        NodeDialog nodeDialog = new NodeDialog(e, panel2, db);
                        nodeDialog.ShowDialog();
                        
                    }
                    else
                    {
                        selected = node;
                    }

                    break;
                case 2:
                    node = clicked(e);
                    if (selected != null && node != null)
                    {
                        ArcDialog arcDialog = new ArcDialog(e, panel2, selected, node, db);
                        arcDialog.Show();
                        selected = null;
                    }
                    else if (node != null)
                    {
                        selected = node;
                    }
                    else
                    {
                        selected = null;
                    }
                    break;
                case 3:
                    GraphObject graphObject = objectClicked(e);
                    if (graphObject != null)
                    {
                        Label.Text = graphObject.Name;
                        // Temporary, replace with feature properties
                        CoordinateX.Text = graphObject.Location().X.ToString();
                        CoordinateY.Text = graphObject.Location().Y.ToString();

                        Label.Visible = true;
                        CoordinateX.Visible = true;
                        CoordinateY.Visible = true;

                        LabelName.Visible = true;
                        LabelCoordinateX.Visible = true;
                        LabelCoordinateY.Visible = true;
                    }
                    break;
            }
        }

        private Node clicked(MouseEventArgs e)
        {
            foreach (Node node in db.Nodes)
            {
                if (e.X >= node.CoordinateX && e.X <= node.CoordinateX + 10)
                {
                    if (e.Y >= node.CoordinateY && e.Y <= node.CoordinateY + 10)
                    {
                        return node;
                    }
                }
            }

            return null;
        }

        private Models.GraphObject objectClicked(MouseEventArgs e)
        {
            foreach (GraphObject graphObject in db.GraphObjects.ToList())
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
