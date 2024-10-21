using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
            comboBox1.Items.Add("Cash");
            comboBox1.Items.Add("Card");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-1VNNIKF\\SQLEXPRESS01;Initial Catalog=CoffeeShop;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Payment values(@Pay_Id, @Date, @Ord_Id, @Name, @Method)", con);
            string selectedMethod = comboBox1.SelectedItem.ToString();
            DateTime selectedDate = dateTimePicker1.Value;
            cmd.Parameters.AddWithValue("@Pay_Id", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Date", selectedDate);
            cmd.Parameters.AddWithValue("@Ord_Id", int.Parse(textBox3.Text));
            cmd.Parameters.AddWithValue("@Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@Method", selectedMethod);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successful", "Success", MessageBoxButtons.OK);
            Form1 f1 = new Form1();
            f1.Show();
            Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Payment_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Menu m1 = new Menu();
            m1.Show();
            Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AboutUs a1 = new AboutUs();
            a1.Show();
            Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Contact c1= new Contact();
            c1.Show();
            Visible= false;
        }
    }
}
