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
    public partial class Light : Form
    {
        public Light()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.panel1.CreateGraphics();
            Pen p = new Pen(Color.FromArgb(214, 213, 197), 10);
            g.DrawEllipse(p, 10, 10, 10, 10);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cart_label4.Text.Length == 0)
            {
                cart_label4.Text = 1.ToString();
            }
            else
            {
                int items = int.Parse(cart_label4.Text);
                items += 1;
                cart_label4.Text = items.ToString();
            }

            string message = "Item added Successfully";
            MessageBox.Show(message);
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Point pt = this.PointToScreen(cart_label4.Location);
            cart_label4.Parent = cart_pic4;
            cart_label4.Location = cart_pic4.PointToClient(pt);
            cart_label4.BackColor = Color.Transparent;
        }

        private void label18_Click(object sender, EventArgs e)
        {
            Table table = new Table();
            this.Hide();
            table.ShowDialog();
            this.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Sofa sofa = new Sofa();
            this.Hide();
            sofa.ShowDialog();
            this.Close();
        }

        private void cart_pic4_Click(object sender, EventArgs e)
        {

        }
    }
}
