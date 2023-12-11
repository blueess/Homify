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
    public partial class Bathroom : Form
    {
        public Bathroom()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Bathtub bathtub = new Bathtub();
            this.Hide();
            bathtub.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bathtub bathtub = new Bathtub();
            this.Hide();
            bathtub.ShowDialog();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Mirror mirror = new Mirror();
            this.Hide();
            mirror.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mirror mirror = new Mirror();
            this.Hide();
            mirror.ShowDialog();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Sink sink = new Sink();
            this.Hide();
            sink.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sink sink = new Sink();
            this.Hide();
            sink.ShowDialog();
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Cabinet cabinet = new Cabinet();
            this.Hide();
            cabinet.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cabinet cabinet = new Cabinet();
            this.Hide();
            cabinet.ShowDialog();
            this.Close();
        }
    
    }
}
