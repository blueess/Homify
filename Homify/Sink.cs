using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Sink : Form
    {
        public Sink()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cart2_label3.Text.Length == 0)
            {
                cart2_label3.Text = 1.ToString();
            }
            else
            {
                int items = int.Parse(cart2_label3.Text);
                items += 1;
                cart2_label3.Text = items.ToString();
            }

            string message = "Item added Successfully";
            MessageBox.Show(message);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Bathroom bathroom = new Bathroom();
            this.Hide();
            bathroom.ShowDialog();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.panel1.CreateGraphics();
            Pen p = new Pen(Color.FromArgb(221, 222, 218), 10);
            g.DrawEllipse(p, 10, 10, 10, 10);
        }

        private void Sink_Load(object sender, EventArgs e)
        {
            Point pt = this.PointToScreen(cart2_label3.Location);
            cart2_label3.Parent = cart2_pic3;
            cart2_label3.Location = cart2_pic3.PointToClient(pt);
            cart2_label3.BackColor = Color.Transparent;
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            Cabinet cabinet = new Cabinet();
            this.Hide();
            cabinet.ShowDialog();
            this.Close();
        }

        private void label19_Click(object sender, EventArgs e)
        {
            Mirror mirror = new Mirror();
            this.Hide();
            mirror.ShowDialog();
            this.Close();
        }
    }
}
