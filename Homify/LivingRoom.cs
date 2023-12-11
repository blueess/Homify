namespace Project
{
    public partial class LivingRoom : Form
    {
        public LivingRoom()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Chair form2 = new Chair();
            this.Hide();
            form2.ShowDialog();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Chair form2 = new Chair();
            this.Hide();
            form2.ShowDialog();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Table form3 = new Table();
            this.Hide();
            form3.ShowDialog();
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Table form3 = new Table();
            this.Hide();
            form3.ShowDialog();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Light form4 = new Light();
            this.Hide();
            form4.ShowDialog();
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Light form4 = new Light();
            this.Hide();
            form4.ShowDialog();
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Sofa form5 = new Sofa();
            this.Hide();
            form5.ShowDialog();
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Sofa form5 = new Sofa();
            this.Hide();
            form5.ShowDialog();
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Point pt = this.PointToScreen(cart_label.Location);
            cart_label.Parent = cart_pic1;
            cart_label.Location = cart_pic1.PointToClient(pt);
            cart_label.BackColor = Color.Transparent;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Chair form2 = new Chair();
            this.Hide();
            form2.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Table form3 = new Table();
            this.Hide();
            form3.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Light form4 = new Light();
            this.Hide();
            form4.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sofa form5 = new Sofa();
            this.Hide();
            form5.ShowDialog();
            this.Close();
        }   

        private void button5_Click(object sender, EventArgs e)
        {
            Bathroom bathroom = new Bathroom();
            this.Hide();
            bathroom.ShowDialog();
            this.Close();
        }
    }
}
