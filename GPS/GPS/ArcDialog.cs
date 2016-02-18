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
    public partial class ArcDialog : Form
    {
        private Node startNode;
        private Node endNode;
        private Panel panel;
        private GPSContext db;

        public ArcDialog()
        {
            InitializeComponent();
        }
        public ArcDialog(MouseEventArgs e, Panel panel, Node startNode, Node endNode, GPSContext db)
        {
            InitializeComponent();
            this.db = db;
            this.panel = panel;
            this.startNode = startNode;
            this.endNode = endNode;

            labelStartNodeValue.Text = startNode.Name;
            labelEndNodeValue.Text = endNode.Name;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxArcName.Text.Length == 0)
            {
                MessageBox.Show("Please provide arc name", "Warning");
            }
            else
            {
                db.Arcs.Add(new Arc(textBoxArcName.Text, startNode, endNode));
                db.SaveChanges();

                panel.Refresh();
                this.Close();
            }
        }
    }
}
