namespace CoffeeShop
{
    partial class Order
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
            button4 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            button6 = new Button();
            button5 = new Button();
            button7 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            comboCategory = new ComboBox();
            comboQuantity = new ComboBox();
            button1 = new Button();
            label5 = new Label();
            label6 = new Label();
            Price = new TextBox();
            Total = new TextBox();
            label7 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dataGridView1 = new DataGridView();
            label8 = new Label();
            Ord_Id = new TextBox();
            Item_Id = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Peru;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1924, 130);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(156, 0);
            button4.Name = "button4";
            button4.Size = new Size(112, 48);
            button4.TabIndex = 7;
            button4.Text = "Back";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(985, 55);
            label1.Name = "label1";
            label1.Size = new Size(174, 54);
            label1.TabIndex = 1;
            label1.Text = "ORDER";
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
            // panel2
            // 
            panel2.BackColor = Color.Peru;
            panel2.Controls.Add(button6);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button7);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 649);
            panel2.Name = "panel2";
            panel2.Size = new Size(1924, 145);
            panel2.TabIndex = 1;
            // 
            // button6
            // 
            button6.BackColor = Color.Peru;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Popup;
            button6.Location = new Point(1016, 63);
            button6.Name = "button6";
            button6.Size = new Size(112, 34);
            button6.TabIndex = 17;
            button6.Text = "ABOUT";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Peru;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Popup;
            button5.Location = new Point(1016, 103);
            button5.Name = "button5";
            button5.Size = new Size(112, 34);
            button5.TabIndex = 16;
            button5.Text = "CONTACT";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Peru;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Popup;
            button7.Location = new Point(1016, 23);
            button7.Name = "button7";
            button7.Size = new Size(112, 34);
            button7.TabIndex = 15;
            button7.Text = "MENU";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(253, 264);
            label2.Name = "label2";
            label2.Size = new Size(118, 32);
            label2.TabIndex = 2;
            label2.Text = "Category";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(253, 361);
            label3.Name = "label3";
            label3.Size = new Size(99, 32);
            label3.TabIndex = 3;
            label3.Text = "Item_Id";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(253, 404);
            label4.Name = "label4";
            label4.Size = new Size(113, 32);
            label4.TabIndex = 4;
            label4.Text = "Quantity";
            // 
            // comboCategory
            // 
            comboCategory.FormattingEnabled = true;
            comboCategory.Location = new Point(465, 267);
            comboCategory.Name = "comboCategory";
            comboCategory.Size = new Size(300, 33);
            comboCategory.TabIndex = 5;
            comboCategory.SelectedIndexChanged += comboCategory_SelectedIndexChanged;
            // 
            // comboQuantity
            // 
            comboQuantity.FormattingEnabled = true;
            comboQuantity.Location = new Point(465, 407);
            comboQuantity.Name = "comboQuantity";
            comboQuantity.Size = new Size(300, 33);
            comboQuantity.TabIndex = 7;
            comboQuantity.SelectedIndexChanged += comboQuantity_SelectedIndexChanged;
            comboQuantity.ValueMemberChanged += comboQuantity_ValueMemberChanged;
            comboQuantity.KeyUp += comboQuantity_KeyUp;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(1212, 446);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 8;
            button1.Text = "Order";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(253, 450);
            label5.Name = "label5";
            label5.Size = new Size(133, 32);
            label5.TabIndex = 9;
            label5.Text = "Price_Item";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.Location = new Point(790, 449);
            label6.Name = "label6";
            label6.Size = new Size(70, 32);
            label6.TabIndex = 10;
            label6.Text = "Total";
            // 
            // Price
            // 
            Price.Location = new Point(465, 450);
            Price.Name = "Price";
            Price.Size = new Size(300, 31);
            Price.TabIndex = 11;
            Price.TextChanged += Price_TextChanged;
            // 
            // Total
            // 
            Total.Location = new Point(872, 449);
            Total.Name = "Total";
            Total.Size = new Size(300, 31);
            Total.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(253, 312);
            label7.Name = "label7";
            label7.Size = new Size(67, 32);
            label7.TabIndex = 13;
            label7.Text = "Date";
            label7.Click += label7_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(465, 313);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 14;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(887, 196);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(804, 228);
            dataGridView1.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(253, 224);
            label8.Name = "label8";
            label8.Size = new Size(90, 32);
            label8.TabIndex = 16;
            label8.Text = "Ord_Id";
            // 
            // Ord_Id
            // 
            Ord_Id.Location = new Point(465, 227);
            Ord_Id.Name = "Ord_Id";
            Ord_Id.Size = new Size(300, 31);
            Ord_Id.TabIndex = 18;
            // 
            // Item_Id
            // 
            Item_Id.Location = new Point(465, 364);
            Item_Id.Name = "Item_Id";
            Item_Id.Size = new Size(300, 31);
            Item_Id.TabIndex = 19;
            Item_Id.KeyUp += Item_Id_KeyUp;
            // 
            // Order
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(1924, 794);
            Controls.Add(Item_Id);
            Controls.Add(Ord_Id);
            Controls.Add(label8);
            Controls.Add(dataGridView1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label7);
            Controls.Add(Total);
            Controls.Add(Price);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(comboQuantity);
            Controls.Add(comboCategory);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Order";
            Text = "Order";
            Load += Order_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox comboCategory;
        private ComboBox comboQuantity;
        private Button button1;
        private Button button6;
        private Button button5;
        private Button button7;
        private Label label5;
        private Label label6;
        private TextBox Price;
        private TextBox Total;
        private Label label7;
        private DateTimePicker dateTimePicker1;
        private DataGridView dataGridView1;
        private Label label8;
        private TextBox Ord_Id;
        private TextBox Item_Id;
        private Button button4;
    }
}