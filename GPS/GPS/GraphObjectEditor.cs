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

namespace GPS
{
    public partial class GraphObjectEditor : UserControl
    {
        private readonly Control[] editControls;

        private GraphObject graphObject;
        private bool editing;
        private ISpecificsEditor specificsEditor;
        public GPSContext DbContext;

        protected interface ISpecificsEditor
        {
            bool Editing { set; }
            bool Visible { set; }
            void updateObject();
            void showObjectData();
            void removeObject();
        }

        
        public GraphObjectEditor()
        {
            InitializeComponent();
            editControls = new Control[]
            {
                nameBox,
            };
            GraphObject = new Node();
            showObjectData();
        }

        public GraphObject GraphObject
        {
            get { return graphObject; }
            set {
                graphObject = value;
                if (specificsEditor != null)
                {
                    specificsEditor.Visible = false;
                }
                if (graphObject is Node)
                {
                    specificsEditor = new NodeSpecificsEditor(
                        this, graphObject as Node);
                }
                else if (graphObject is Arc)
                {
                    specificsEditor = new ArcSpecificsEditor(
                        this, graphObject as Arc);
                }
                else
                {
                    throw new ArgumentException("unsuported graph object");
                }
                specificsEditor.Visible = true;
                Editing = false;
            }
        }

        public bool Editing
        {
            get { return editing; }
            set
            {
                editing = value;
                specificsEditor.Editing = value;
                if (editing)
                {
                    foreach(var control in editControls)
                    {
                        control.Enabled = true;
                    }
                    editButton.Visible = false;
                    deleteButton.Visible = false;
                    saveButton.Visible = true;
                    cancelButton.Visible = true;

                }
                else
                {
                    foreach (var control in editControls)
                    {
                        control.Enabled = false;
                    }
                    editButton.Visible = true;
                    deleteButton.Visible = true;
                    saveButton.Visible = false;
                    cancelButton.Visible = false;
                    showObjectData();
                }
            }
        }

        private void showObjectData()
        {
            nameBox.Text = graphObject.Name;
            idBox.Text = graphObject.GraphObjectId.ToString();
            specificsEditor.showObjectData();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            Editing = true;
        }

        private void updateObject()
        {
            graphObject.Name = nameBox.Text;
            specificsEditor.updateObject();
            DbContext.SaveChanges();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Editing = false;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            updateObject();
            Editing = false;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            specificsEditor.removeObject();
            DbContext.SaveChanges();
            GraphObject = new Node();
        }

        protected class NodeSpecificsEditor : ISpecificsEditor
        {
            private GraphObjectEditor parent;
            private Node node;
            private Control[] editControls;

            public NodeSpecificsEditor(GraphObjectEditor parent, Node node)
            {
                this.parent = parent;
                this.node = node;
                editControls = new Control[]
                {
                    parent.coordSelectorX,
                    parent.coordSelectorY,
                };
            }

            public bool Visible
            {
                set { parent.nodePanel.Visible = value; }
            }

            public bool Editing
            {
                set
                {
                    foreach (var control in editControls)
                    {
                        control.Enabled = value;
                    }
                    showObjectData();
                }
            }

            public void updateObject()
            {
                node.CoordinateX = Convert.ToInt32(
                    parent.coordSelectorX.Value);
                node.CoordinateY = Convert.ToInt32(
                    parent.coordSelectorY.Value);
                if (node.GraphObjectId == 0)
                {
                    parent.DbContext.Nodes.Add(node);
                }
            }

            public void showObjectData()
            {
                parent.coordSelectorX.Value = node.CoordinateX;
                parent.coordSelectorY.Value = node.CoordinateY;
            }

            public void removeObject()
            {
                if (node.GraphObjectId != 0)
                {
                    parent.DbContext.Nodes.Remove(node);
                }
            }
        }

        protected class ArcSpecificsEditor : ISpecificsEditor
        {
            private GraphObjectEditor parent;
            private Arc arc;
            private Control[] editControls;

            public ArcSpecificsEditor(GraphObjectEditor parent, Arc arc)
            {
                this.parent = parent;
                this.arc = arc;
                editControls = new Control[]
                {
                    // parent.startNodeBox,
                    // parent.endNodeBox,
                    parent.directedBox
                };
            }
            
            public bool Visible
            {
                set { parent.arcPanel.Visible = value; }
            }

            public bool Editing
            {
                set
                {
                    foreach (var control in editControls)
                    {
                        control.Enabled = value;
                    }
                    showObjectData();
                }
            }

            public void updateObject()
            {
                arc.Directed = parent.directedBox.Checked;
                if (arc.GraphObjectId == 0)
                {
                    parent.DbContext.Arcs.Add(arc);
                }
            }

            public void showObjectData()
            {
                parent.startNodeBox.Text = arc.StartNode.Name;
                parent.endNodeBox.Text = arc.EndNode.Name;
                parent.directedBox.Checked = arc.Directed;
            }

            public void removeObject()
            {
                if (arc.GraphObjectId != 0)
                {
                    parent.DbContext.Arcs.Remove(arc);
                }
            }
        }
    }
}
