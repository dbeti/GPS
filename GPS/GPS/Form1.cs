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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            Node node = new Node();

            try
            {
                node.CoordinateX = Convert.ToInt32(this.textBox1.Text);
                node.CoordinateY = Convert.ToInt32(this.textBox2.Text);
                db.Nodes.Add(node);
                db.SaveChanges();
                panel2.Refresh();
            }
            catch(FormatException formatException)
            {
                MessageBox.Show("Please enter valid values for coordinates", "Warning");
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            foreach(Node node in db.Nodes.ToList())
            {
                e.Graphics.DrawEllipse(Pens.Red, node.CoordinateX, node.CoordinateY, 10, 10);
            }
        }
    }
}
