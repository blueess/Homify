namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.panel1.CreateGraphics();
            Pen p = new Pen(Color.FromArgb(209, 203, 165), 10);
            g.DrawEllipse(p, 10, 10, 10, 10);
        }
    }
}
