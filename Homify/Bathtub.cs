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
    public partial class Bathtub : Form
    {
        public Bathtub()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cart2_label1.Text.Length == 0)
            {
                cart2_label1.Text = 1.ToString();
            }
            else
            {
                int items = int.Parse(cart2_label1.Text);
                items += 1;
                cart2_label1.Text = items.ToString();
            }

            string message = "Item added Successfully";
            MessageBox.Show(message);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Mirror mirror = new Mirror();
            this.Hide();
            mirror.ShowDialog();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.panel1.CreateGraphics();
            Pen p = new Pen(Color.FromArgb(144, 144, 144), 10);
            g.DrawEllipse(p, 10, 10, 10, 10);
        }

        private void Bathtub_Load(object sender, EventArgs e)
        {
            Point pt = this.PointToScreen(cart2_label1.Location);
            cart2_label1.Parent = cart2_pic2;
            cart2_label1.Location = cart2_pic2.PointToClient(pt);
            cart2_label1.BackColor = Color.Transparent;
        }

        private void label19_Click(object sender, EventArgs e)
        {
            Bathroom bathroom = new Bathroom();
            this.Hide();
            bathroom.ShowDialog();
            this.Close();
        }
    }
}
