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
    public partial class Sofa : Form
    {
        public Sofa()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.panel1.CreateGraphics();
            Pen p = new Pen(Color.FromArgb(94, 105, 75), 10);
            g.DrawEllipse(p, 10, 10, 10, 10);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cart_label5.Text.Length == 0)
            {
                cart_label5.Text = 1.ToString();
            }
            else
            {
                int items = int.Parse(cart_label5.Text);
                items += 1;
                cart_label5.Text = items.ToString();
            }

            string message = "Item added Successfully";
            MessageBox.Show(message);
        }


        private void Form5_Load(object sender, EventArgs e)
        {
            Point pt = this.PointToScreen(cart_label5.Location);
            cart_label5.Parent = cart_pic5;
            cart_label5.Location = cart_pic5.PointToClient(pt);
            cart_label5.BackColor = Color.Transparent;
        }

        private void label18_Click(object sender, EventArgs e)
        {
            Light light = new Light();
            this.Hide();
            light.ShowDialog();
            this.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            LivingRoom room = new LivingRoom();
            this.Hide();
            room.ShowDialog();
            this.Close();
        }
    }
}
