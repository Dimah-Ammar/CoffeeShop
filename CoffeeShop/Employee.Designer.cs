namespace CoffeeShop
{
    partial class Employee
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            button4 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            name_textBox1 = new TextBox();
            password_textBox2 = new TextBox();
            address_textBox3 = new TextBox();
            email_textBox4 = new TextBox();
            phone_textBox5 = new TextBox();
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label9 = new Label();
            designation_textBox6 = new TextBox();
            label10 = new Label();
            adm_id_textBox7 = new TextBox();
            button5 = new Button();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(980, 189);
            label1.Name = "label1";
            label1.Size = new Size(231, 32);
            label1.TabIndex = 1;
            label1.Text = "EMPLOYEE/ADMIN";
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
            // panel1
            // 
            panel1.BackColor = Color.Peru;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1924, 130);
            panel1.TabIndex = 0;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(156, 3);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 6;
            button4.Text = "Back";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Peru;
            label2.Font = new Font("Stencil", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(176, 47);
            label2.Name = "label2";
            label2.Size = new Size(520, 61);
            label2.TabIndex = 5;
            label2.Text = "THE COFFEE HOUSE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(575, 311);
            label3.Name = "label3";
            label3.Size = new Size(62, 25);
            label3.TabIndex = 2;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(575, 359);
            label4.Name = "label4";
            label4.Size = new Size(92, 25);
            label4.TabIndex = 3;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(571, 415);
            label5.Name = "label5";
            label5.Size = new Size(80, 25);
            label5.TabIndex = 4;
            label5.Text = "Address";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(571, 466);
            label6.Name = "label6";
            label6.Size = new Size(58, 25);
            label6.TabIndex = 5;
            label6.Text = "Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(571, 510);
            label7.Name = "label7";
            label7.Size = new Size(66, 25);
            label7.TabIndex = 6;
            label7.Text = "Phone";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(571, 552);
            label8.Name = "label8";
            label8.Size = new Size(74, 25);
            label8.TabIndex = 7;
            label8.Text = "Gender";
            // 
            // name_textBox1
            // 
            name_textBox1.Location = new Point(769, 305);
            name_textBox1.Name = "name_textBox1";
            name_textBox1.Size = new Size(182, 31);
            name_textBox1.TabIndex = 8;
            // 
            // password_textBox2
            // 
            password_textBox2.Location = new Point(769, 356);
            password_textBox2.Name = "password_textBox2";
            password_textBox2.Size = new Size(182, 31);
            password_textBox2.TabIndex = 9;
            // 
            // address_textBox3
            // 
            address_textBox3.Location = new Point(769, 415);
            address_textBox3.Name = "address_textBox3";
            address_textBox3.Size = new Size(182, 31);
            address_textBox3.TabIndex = 10;
            // 
            // email_textBox4
            // 
            email_textBox4.Location = new Point(769, 466);
            email_textBox4.Name = "email_textBox4";
            email_textBox4.Size = new Size(182, 31);
            email_textBox4.TabIndex = 11;
            // 
            // phone_textBox5
            // 
            phone_textBox5.Location = new Point(769, 510);
            phone_textBox5.Name = "phone_textBox5";
            phone_textBox5.Size = new Size(182, 31);
            phone_textBox5.TabIndex = 12;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(769, 552);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 13;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(1058, 229);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(598, 389);
            dataGridView1.TabIndex = 14;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.Location = new Point(691, 639);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 15;
            button1.Text = "UPDATE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button2.Location = new Point(809, 639);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 16;
            button2.Text = "DELETE";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button3.Location = new Point(927, 639);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 17;
            button3.Text = "SEARCH";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(571, 593);
            label9.Name = "label9";
            label9.Size = new Size(114, 25);
            label9.TabIndex = 18;
            label9.Text = "Designation";
            // 
            // designation_textBox6
            // 
            designation_textBox6.Location = new Point(769, 593);
            designation_textBox6.Name = "designation_textBox6";
            designation_textBox6.Size = new Size(182, 31);
            designation_textBox6.TabIndex = 20;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(575, 263);
            label10.Name = "label10";
            label10.Size = new Size(76, 25);
            label10.TabIndex = 21;
            label10.Text = "Adm_Id";
            // 
            // adm_id_textBox7
            // 
            adm_id_textBox7.Location = new Point(771, 263);
            adm_id_textBox7.Name = "adm_id_textBox7";
            adm_id_textBox7.Size = new Size(180, 31);
            adm_id_textBox7.TabIndex = 22;
            adm_id_textBox7.TextChanged += adm_id_textBox7_TextChanged;
            // 
            // button5
            // 
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(575, 639);
            button5.Name = "button5";
            button5.Size = new Size(112, 34);
            button5.TabIndex = 23;
            button5.Text = "INSERT";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(1045, 639);
            button6.Name = "button6";
            button6.Size = new Size(112, 34);
            button6.TabIndex = 24;
            button6.Text = "CLEAR";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Employee
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(1924, 794);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(adm_id_textBox7);
            Controls.Add(label10);
            Controls.Add(designation_textBox6);
            Controls.Add(label9);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox1);
            Controls.Add(phone_textBox5);
            Controls.Add(email_textBox4);
            Controls.Add(address_textBox3);
            Controls.Add(password_textBox2);
            Controls.Add(name_textBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Employee";
            Text = "Employee";
            Load += Employee_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox name_textBox1;
        private TextBox password_textBox2;
        private TextBox address_textBox3;
        private TextBox email_textBox4;
        private TextBox phone_textBox5;
        private ComboBox comboBox1;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label9;
        private TextBox designation_textBox6;
        private Label label10;
        private TextBox adm_id_textBox7;
        private Button button5;
        private Button button6;
    }
}