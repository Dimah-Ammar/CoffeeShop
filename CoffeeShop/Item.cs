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
    public partial class Item : Form
    {
        public Item()
        {
            InitializeComponent();
            comboBox1.Items.Add("Coffee");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-1VNNIKF\\SQLEXPRESS01;Initial Catalog=CoffeeShop;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Item values(@Item_Id, @Item_Name, @Price, @Description, @Category)", con);
            string selectedCategory = comboBox1.SelectedItem.ToString();
            cmd.Parameters.AddWithValue("@Item_Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@Description", textBox4.Text);
            cmd.Parameters.AddWithValue("@Price", int.Parse(textBox3.Text));
            cmd.Parameters.AddWithValue("@Category", selectedCategory);
            cmd.Parameters.AddWithValue("@Item_Id", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Inserted Successfully", "Success", MessageBoxButtons.OK);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-1VNNIKF\\SQLEXPRESS01;Initial Catalog=CoffeeShop;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("update Item set  Item_Id=@Item_Id, Item_Name=@Item_Name, Price=@Price, Description=@Description, Category=@Category where Item_Id=@Item_Id", con);
            string selectedCategory = comboBox1.SelectedItem.ToString();
            cmd.Parameters.AddWithValue("@Item_Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@Description", textBox4.Text);
            cmd.Parameters.AddWithValue("@Price", int.Parse(textBox3.Text));
            cmd.Parameters.AddWithValue("@Category", selectedCategory);
            cmd.Parameters.AddWithValue("@Item_Id", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated Successfully", "Success", MessageBoxButtons.OK);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-1VNNIKF\\SQLEXPRESS01;Initial Catalog=CoffeeShop;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete Item where Item_Id=@Item_Id", con);
            cmd.Parameters.AddWithValue("@Item_Id", textBox1.Text);
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
                SqlCommand cmd = new SqlCommand("Select * from Item", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (textBox1.Text != "")
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-1VNNIKF\\SQLEXPRESS01;Initial Catalog=CoffeeShop;Integrated Security=True;TrustServerCertificate=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from Item where item_Id= '" + textBox1.Text + "'", con);
                // cmd.Parameters.AddWithValue("@Name", name_textBox1);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Dashboard d1 = new Dashboard();
            d1.Show();
            Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
           
        }
    }
}
