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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CoffeeShop
{
    public partial class Payments : Form
    {
        public Payments()
        {
            InitializeComponent();
            comboBox1.Items.Add("Cash");
            comboBox1.Items.Add("Card");

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Dashboard d1 = new Dashboard();
            d1.Show();
            Visible = false;
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
            cmd.Parameters.AddWithValue("@Ord_Id", int.Parse(textBox2.Text));
            cmd.Parameters.AddWithValue("@Name", textBox3.Text);
            cmd.Parameters.AddWithValue("@Method", selectedMethod);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Inserted Successfully", "Success", MessageBoxButtons.OK);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-1VNNIKF\\SQLEXPRESS01;Initial Catalog=CoffeeShop;Integrated Security=True;TrustServerCertificate=True"))
            {
                con.Open();
                string query = "UPDATE [Payment] SET  Pay_Id=@Pay_Id, Date=@Date, Ord_Id=@Ord_Id, Method=@Method where Pay_Id=@Pay_Id";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    string selectedMethod = comboBox1.SelectedItem.ToString();
                    DateTime selectedDate = dateTimePicker1.Value;
                    cmd.Parameters.AddWithValue("@Pay_Id", int.Parse(textBox1.Text));
                    cmd.Parameters.AddWithValue("@Date", selectedDate);
                    cmd.Parameters.AddWithValue("@Ord_Id", int.Parse(textBox2.Text));
                    cmd.Parameters.AddWithValue("@Name", textBox3.Text);
                    cmd.Parameters.AddWithValue("@Method", selectedMethod);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            MessageBox.Show("Updated Successfully", "Success", MessageBoxButtons.OK);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-1VNNIKF\\SQLEXPRESS01;Initial Catalog=CoffeeShop;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete Payment where Pay_Id=@Pay_Id", con);
            cmd.Parameters.AddWithValue("@Pay_Id", textBox1.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Deleted Successfully", "Success", MessageBoxButtons.OK);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-1VNNIKF\\SQLEXPRESS01;Initial Catalog=CoffeeShop;Integrated Security=True;TrustServerCertificate=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from Payment", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (textBox1.Text != "")
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-1VNNIKF\\SQLEXPRESS01;Initial Catalog=CoffeeShop;Integrated Security=True;TrustServerCertificate=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from Payment where Pay_Id= '" + textBox1.Text + "'", con);
                // cmd.Parameters.AddWithValue("@Name", name_textBox1);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            
        }
    }
}
