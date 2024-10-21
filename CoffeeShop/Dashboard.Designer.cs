namespace CoffeeShop
{
    partial class Dashboard
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
            panel1 = new Panel();
            button11 = new Button();
            button10 = new Button();
            button8 = new Button();
            button7 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Peru;
            panel1.Controls.Add(button11);
            panel1.Controls.Add(button10);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1924, 130);
            panel1.TabIndex = 0;
            // 
            // button11
            // 
            button11.FlatAppearance.BorderSize = 0;
            button11.FlatStyle = FlatStyle.Flat;
            button11.Font = new Font("Segoe UI", 8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            button11.Location = new Point(1620, 68);
            button11.Name = "button11";
            button11.Size = new Size(112, 34);
            button11.TabIndex = 12;
            button11.Text = "PAYMENTS";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // button10
            // 
            button10.FlatAppearance.BorderSize = 0;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("Segoe UI", 8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            button10.Location = new Point(1539, 68);
            button10.Name = "button10";
            button10.Size = new Size(87, 34);
            button10.TabIndex = 11;
            button10.Text = "STOCK";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button8
            // 
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Segoe UI", 8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            button8.Location = new Point(1176, 68);
            button8.Name = "button8";
            button8.Size = new Size(112, 34);
            button8.TabIndex = 10;
            button8.Text = "EMPLOYEE";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI", 8F, FontStyle.Bold | FontStyle.Underline);
            button7.Location = new Point(1072, 68);
            button7.Name = "button7";
            button7.Size = new Size(112, 34);
            button7.TabIndex = 9;
            button7.Text = "REGISTER";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 8F, FontStyle.Bold | FontStyle.Underline);
            button3.Location = new Point(1471, 68);
            button3.Name = "button3";
            button3.Size = new Size(87, 34);
            button3.TabIndex = 8;
            button3.Text = "ITEMS";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 8F, FontStyle.Bold | FontStyle.Underline);
            button2.Location = new Point(1389, 68);
            button2.Name = "button2";
            button2.Size = new Size(90, 34);
            button2.TabIndex = 7;
            button2.Text = "ORDERS";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 8F, FontStyle.Bold | FontStyle.Underline);
            button1.Location = new Point(1283, 68);
            button1.Name = "button1";
            button1.Size = new Size(114, 34);
            button1.TabIndex = 6;
            button1.Text = "CUSTOMERS";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Peru;
            label1.Font = new Font("Stencil", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(177, 25);
            label1.Name = "label1";
            label1.Size = new Size(520, 61);
            label1.TabIndex = 5;
            label1.Text = "THE COFFEE HOUSE";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = Properties.Resources.logo2;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 130);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = Properties.Resources.admin;
            pictureBox2.Location = new Point(0, 130);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1924, 664);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 794);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Name = "Dashboard";
            Text = "Dashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label1;
        private Button button7;
        private Button button8;
        private Button button10;
        private Button button11;
        private PictureBox pictureBox2;
    }
}