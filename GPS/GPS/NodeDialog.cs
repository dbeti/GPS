using GPS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPS
{
    public partial class NodeDialog : Form
    {
        private GPSContext db;
        private Panel panel;

        public NodeDialog()
        {
            InitializeComponent();
        }

        public NodeDialog(MouseEventArgs e, Panel panel, GPSContext db)
        {
            this.db = db;
            this.panel = panel;
            InitializeComponent();
            this.textBoxCoordinateX.Text = e.X.ToString();
            this.textBoxCoordinateY.Text = e.Y.ToString();

            
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text.Length == 0)
            {
                MessageBox.Show("Please provide node name", "Warning");
            }
            else
            {
                db.Nodes.Add(new Node(textBoxName.Text, Convert.ToInt32(textBoxCoordinateX.Text), Convert.ToInt32(textBoxCoordinateY.Text)));
                db.SaveChanges();

                panel.Refresh();
                this.Close();
            }
        }
    }
}
