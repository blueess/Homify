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
    public partial class Chair : Form
    {
        public Chair()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Table table = new Table();
            this.Hide();
            table.ShowDialog();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.panel1.CreateGraphics();
            Pen p = new Pen(Color.FromArgb(133, 169, 190), 10);
            g.DrawEllipse(p, 10, 10, 10, 10);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cart_label2.Text.Length == 0)
            {
                cart_label2.Text = 1.ToString();
            }
            else
            {
                int items = int.Parse(cart_label2.Text);
                items += 1;
                cart_label2.Text = items.ToString();
            }

            string message = "Item added Successfully";
            MessageBox.Show(message);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Point pt = this.PointToScreen(cart_label2.Location);
            cart_label2.Parent = cart_pic2;
            cart_label2.Location = cart_pic2.PointToClient(pt);
            cart_label2.BackColor = Color.Transparent;
        }

        private void label11_Click(object sender, EventArgs e)
        {
            LivingRoom livingRoom = new LivingRoom();
            this.Hide();
            livingRoom.ShowDialog();
            this.Close();
        }
    }
}
