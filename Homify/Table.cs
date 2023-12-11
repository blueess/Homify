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
    public partial class Table : Form
    {
        public Table()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.panel1.CreateGraphics();
            Pen p = new Pen(Color.FromArgb(204, 155, 89), 10);
            g.DrawEllipse(p, 10, 10, 10, 10);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cart_label3.Text.Length == 0)
            {
                cart_label3.Text = 1.ToString();
            }
            else
            {
                int items = int.Parse(cart_label3.Text);
                items += 1;
                cart_label3.Text = items.ToString();
            }

            string message = "Item added Successfully";
            MessageBox.Show(message);
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Light light = new Light();
            this.Hide();
            light.ShowDialog();
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Point pt = this.PointToScreen(cart_label3.Location);
            cart_label3.Parent = cart_pic3;
            cart_label3.Location = cart_pic3.PointToClient(pt);
            cart_label3.BackColor = Color.Transparent;
        }

        private void label18_Click(object sender, EventArgs e)
        {
            Chair chair = new Chair();
            this.Hide();
            chair.ShowDialog();
            this.Close();
        }
    }
}
