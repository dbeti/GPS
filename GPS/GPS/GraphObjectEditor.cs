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
        
        private GraphObject graphObject;
        private bool editing;
        private ISpecificsEditor specificsEditor;

        public GPSContext DbContext;

        public enum ChangeKind { Created, Deleted, Updated, Canceled };

        public class GraphObjectEventArgs : EventArgs
        {
            public GraphObject GraphObject;
            public ChangeKind ChangeKind;

            public GraphObjectEventArgs(
                GraphObject graphObject,
                ChangeKind changeKind)
            {
                GraphObject = graphObject;
                ChangeKind = changeKind;
            }
        };

        [Browsable(true)]
        public event EventHandler<GraphObjectEventArgs> GraphObjectUpdated;

        protected virtual void OnGraphObjectUpdated(GraphObjectEventArgs args)
        {
            var handler = GraphObjectUpdated;
            if (handler != null)
            {
                handler(this, args);
            }
        }

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
            GraphObject = new Node();
            showObjectData();
        }

        [Browsable(true), DefaultValue(null)]
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
                    throw new ArgumentException("unsuported GraphObject");
                }
                specificsEditor.Visible = true;
                Editing = false;
            }
        }

        [Browsable(true), DefaultValue(false)]
        public bool Editing
        {
            get { return editing; }
            set
            {
                editing = value;
                specificsEditor.Editing = value;
                
                nameBox.ReadOnly = !value;
                editButton.Visible = !value;
                deleteButton.Visible = !value;
                saveButton.Visible = value;
                cancelButton.Visible = value;

                if (!value)
                {
                    showObjectData();
                }
                
            }
        }

        private void showObjectData()
        {
            nameBox.Text = graphObject.Name;
            idBox.Text = graphObject.GraphObjectId.ToString();
            specificsEditor.showObjectData();
            featureView.Items.Clear();
            if (graphObject.Features != null)
            {
                foreach (var feature in graphObject.Features)
                {
                    var item = new ListViewItem(feature.Name);
                    item.SubItems.Add(feature.FeatureType.Name);
                    item.Tag = feature;
                    featureView.Items.Add(item);
                }
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            Editing = true;
        }

        private void updateObject()
        {
            ChangeKind changeKind = graphObject.GraphObjectId == 0 ? 
                ChangeKind.Created : ChangeKind.Updated;
            graphObject.Name = nameBox.Text;
            specificsEditor.updateObject();
            DbContext.SaveChanges();
            OnGraphObjectUpdated(new GraphObjectEventArgs(
                    graphObject, changeKind));
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Editing = false;
            if (graphObject.GraphObjectId == 0)
            {
                OnGraphObjectUpdated(new GraphObjectEventArgs(
                    graphObject, ChangeKind.Canceled));
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            updateObject();
            Editing = false;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (graphObject.GraphObjectId != 0)
            {
                specificsEditor.removeObject();
                DbContext.SaveChanges();
                GraphObject = new Node();
                OnGraphObjectUpdated(new GraphObjectEventArgs(
                    graphObject, ChangeKind.Deleted));
            }
        }

        protected class NodeSpecificsEditor : ISpecificsEditor
        {
            private GraphObjectEditor parent;
            private Node node;
            
            public NodeSpecificsEditor(GraphObjectEditor parent, Node node)
            {
                this.parent = parent;
                this.node = node;
            }

            public bool Visible
            {
                set { parent.nodePanel.Visible = value; }
            }

            public bool Editing
            {
                set
                {
                    parent.coordSelectorX.ReadOnly = !value;
                    parent.coordSelectorY.ReadOnly = !value;
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
           
            public ArcSpecificsEditor(GraphObjectEditor parent, Arc arc)
            {
                this.parent = parent;
                this.arc = arc;
            }
            
            public bool Visible
            {
                set { parent.arcPanel.Visible = value; }
            }

            public bool Editing
            {
                set
                {
                    parent.directedBox.AutoCheck = value;
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

        private void addFeatureButton_Click(object sender, EventArgs e)
        {
            string name = featureNameBox.Text;
            string typeName = featureTypeBox.Text;
            if (name != "" && typeName != "")
            {
                FeatureType type = DbContext.FeatureTypes
                    .FirstOrDefault(x => x.Name == typeName);
                if (type == null)
                {
                    type = new FeatureType(typeName);
                    DbContext.FeatureTypes.Add(type);
                }
                var feature = new Feature(name, graphObject, type);
                DbContext.Features.Add(feature);
                DbContext.SaveChanges();
                showObjectData();
                featureNameBox.Text = "";
                featureTypeBox.Text = "";
            }
        }

        private void featureView_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            removeFeatureButton.Enabled = featureView.SelectedItems.Count > 0;
        }

        private void removeFeatureButton_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item in featureView.SelectedItems)
            {
                DbContext.Features.Remove(item.Tag as Feature);
            }
            DbContext.SaveChanges();
            removeFeatureButton.Enabled = false;
            showObjectData();
        }
    }
}
