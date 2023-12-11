namespace Project
{
    partial class Chair
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chair));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            sofa_pic1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            cart_pic2 = new PictureBox();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            panel1 = new Panel();
            cart_label2 = new Label();
            label11 = new Label();
            textBox1 = new TextBox();
            label12 = new Label();
            label17 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label18 = new Label();
            label19 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sofa_pic1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cart_pic2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(984, 555);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(19, 85, 75);
            label1.Font = new Font("Script MT Bold", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(350, 8);
            label1.Name = "label1";
            label1.Size = new Size(242, 72);
            label1.TabIndex = 2;
            label1.Text = "H⌂mify";
            // 
            // sofa_pic1
            // 
            sofa_pic1.Image = (Image)resources.GetObject("sofa_pic1.Image");
            sofa_pic1.Location = new Point(44, 164);
            sofa_pic1.Name = "sofa_pic1";
            sofa_pic1.Size = new Size(326, 313);
            sofa_pic1.SizeMode = PictureBoxSizeMode.Zoom;
            sofa_pic1.TabIndex = 3;
            sofa_pic1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(19, 85, 75);
            label2.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(58, 22);
            label2.Name = "label2";
            label2.Size = new Size(40, 41);
            label2.TabIndex = 4;
            label2.Text = ">";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonHighlight;
            label3.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(19, 75, 85);
            label3.Location = new Point(396, 155);
            label3.Name = "label3";
            label3.Size = new Size(168, 31);
            label3.TabIndex = 5;
            label3.Text = "Quentin Chair";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ButtonHighlight;
            label5.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(19, 75, 85);
            label5.Location = new Point(397, 244);
            label5.Name = "label5";
            label5.Size = new Size(79, 28);
            label5.TabIndex = 7;
            label5.Text = "Colors:";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(19, 85, 75);
            button1.FlatAppearance.BorderColor = SystemColors.ButtonFace;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(670, 357);
            button1.Name = "button1";
            button1.Size = new Size(216, 50);
            button1.TabIndex = 9;
            button1.Text = "Add To Cart";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(19, 85, 75);
            button2.FlatAppearance.BorderColor = SystemColors.ButtonHighlight;
            button2.FlatAppearance.BorderSize = 2;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(670, 264);
            button2.Name = "button2";
            button2.Size = new Size(216, 49);
            button2.TabIndex = 9;
            button2.Text = "Buy Item";
            button2.UseVisualStyleBackColor = false;
            // 
            // cart_pic2
            // 
            cart_pic2.BackColor = Color.FromArgb(19, 85, 75);
            cart_pic2.Image = (Image)resources.GetObject("cart_pic2.Image");
            cart_pic2.Location = new Point(900, 8);
            cart_pic2.Name = "cart_pic2";
            cart_pic2.Size = new Size(70, 66);
            cart_pic2.SizeMode = PictureBoxSizeMode.StretchImage;
            cart_pic2.TabIndex = 10;
            cart_pic2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonHighlight;
            label4.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(503, 203);
            label4.Name = "label4";
            label4.Size = new Size(65, 28);
            label4.TabIndex = 11;
            label4.Text = "8,000";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ButtonHighlight;
            label6.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(19, 75, 85);
            label6.Location = new Point(397, 285);
            label6.Name = "label6";
            label6.Size = new Size(83, 28);
            label6.TabIndex = 12;
            label6.Text = "Length:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ButtonHighlight;
            label7.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(19, 75, 85);
            label7.Location = new Point(397, 330);
            label7.Name = "label7";
            label7.Size = new Size(76, 28);
            label7.TabIndex = 13;
            label7.Text = "Width:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.ButtonHighlight;
            label8.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(19, 75, 85);
            label8.Location = new Point(396, 449);
            label8.Name = "label8";
            label8.Size = new Size(106, 28);
            label8.TabIndex = 14;
            label8.Text = "Materials:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.ButtonHighlight;
            label9.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(19, 75, 85);
            label9.Location = new Point(397, 368);
            label9.Name = "label9";
            label9.Size = new Size(82, 28);
            label9.TabIndex = 15;
            label9.Text = "Height:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = SystemColors.ButtonHighlight;
            label10.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(502, 408);
            label10.Name = "label10";
            label10.Size = new Size(88, 28);
            label10.TabIndex = 16;
            label10.Text = "Modern";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Location = new Point(503, 244);
            panel1.Name = "panel1";
            panel1.Size = new Size(40, 35);
            panel1.TabIndex = 22;
            panel1.Paint += panel1_Paint;
            // 
            // cart_label2
            // 
            cart_label2.AutoSize = true;
            cart_label2.BackColor = Color.Transparent;
            cart_label2.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cart_label2.ForeColor = Color.Black;
            cart_label2.Location = new Point(924, 22);
            cart_label2.Name = "cart_label2";
            cart_label2.Size = new Size(0, 34);
            cart_label2.TabIndex = 23;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.FromArgb(19, 85, 75);
            label11.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ButtonHighlight;
            label11.Location = new Point(12, 22);
            label11.Name = "label11";
            label11.Size = new Size(40, 41);
            label11.TabIndex = 35;
            label11.Text = "<";
            label11.Click += label11_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Menu;
            textBox1.ForeColor = Color.Silver;
            textBox1.Location = new Point(730, 73);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(240, 27);
            textBox1.TabIndex = 61;
            textBox1.Text = "What Can We Help You Find Today?";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = SystemColors.ButtonHighlight;
            label12.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.FromArgb(19, 75, 85);
            label12.Location = new Point(397, 202);
            label12.Name = "label12";
            label12.Size = new Size(64, 28);
            label12.TabIndex = 64;
            label12.Text = "Price:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = SystemColors.ButtonHighlight;
            label17.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.FromArgb(19, 85, 75);
            label17.Location = new Point(397, 492);
            label17.Name = "label17";
            label17.Size = new Size(38, 28);
            label17.TabIndex = 70;
            label17.Text = "ID:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = SystemColors.ButtonHighlight;
            label13.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(503, 285);
            label13.Name = "label13";
            label13.Size = new Size(87, 28);
            label13.TabIndex = 71;
            label13.Text = "68.6 cm";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = SystemColors.ButtonHighlight;
            label14.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(503, 330);
            label14.Name = "label14";
            label14.Size = new Size(87, 28);
            label14.TabIndex = 72;
            label14.Text = "82.8 cm";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = SystemColors.ButtonHighlight;
            label15.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(503, 368);
            label15.Name = "label15";
            label15.Size = new Size(87, 28);
            label15.TabIndex = 73;
            label15.Text = "98.4 cm";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = SystemColors.ButtonHighlight;
            label16.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.FromArgb(19, 75, 85);
            label16.Location = new Point(397, 408);
            label16.Name = "label16";
            label16.Size = new Size(65, 28);
            label16.TabIndex = 74;
            label16.Text = "Style:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = SystemColors.ButtonHighlight;
            label18.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(503, 449);
            label18.Name = "label18";
            label18.Size = new Size(198, 28);
            label18.TabIndex = 75;
            label18.Text = "Performance Fabric";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = SystemColors.ButtonHighlight;
            label19.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.ForeColor = SystemColors.ControlText;
            label19.Location = new Point(502, 492);
            label19.Name = "label19";
            label19.Size = new Size(72, 28);
            label19.TabIndex = 76;
            label19.Text = "00012";
            // 
            // Chair
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(982, 553);
            Controls.Add(label19);
            Controls.Add(label18);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label17);
            Controls.Add(label12);
            Controls.Add(textBox1);
            Controls.Add(label11);
            Controls.Add(cart_label2);
            Controls.Add(panel1);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(cart_pic2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(sofa_pic1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            ForeColor = Color.Black;
            Name = "Chair";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)sofa_pic1).EndInit();
            ((System.ComponentModel.ISupportInitialize)cart_pic2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox sofa_pic1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Button button1;
        private Button button2;
        private PictureBox cart_pic2;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Panel panel1;
        public Label cart_label2;
        private Label label11;
        private TextBox textBox1;
        private Label label12;
        private Label label17;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label18;
        private Label label19;
    }
}