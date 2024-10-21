using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop
{
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();
            comboBox1.Items.Add("Coffee");
            for (int i = 1; i <= 10; i++)
            {
                comboBox2.Items.Add(i);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*SqlConnection con = new SqlConnection("Data Source=DESKTOP-1VNNIKF\\SQLEXPRESS01;Initial Catalog=CoffeeShop;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Order values(@Ord_Id, @Date, @Price_item, @Item_id, @Category, @Quantity, @Total_Amount)", con);
            string selectedCategory = comboBox1.SelectedItem.ToString();
            int selectedQuantity = int.Parse(comboBox2.SelectedItem.ToString());
            DateTime selectedDate = dateTimePicker1.Value;
            cmd.Parameters.AddWithValue("@Ord_Id", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Date", selectedDate);
            cmd.Parameters.AddWithValue("@Price_item", decimal.Parse(textBox2.Text));
            cmd.Parameters.AddWithValue("@Item_Id", int.Parse(textBox3.Text));
            cmd.Parameters.AddWithValue("@Category", selectedCategory);
            cmd.Parameters.AddWithValue("@Quantity", selectedQuantity);
            cmd.Parameters.AddWithValue("@Total_Amount", decimal.Parse(textBox4.Text));
            cmd.ExecuteNonQuery();
            con.Close();*/
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-1VNNIKF\\SQLEXPRESS01;Initial Catalog=CoffeeShop;Integrated Security=True;TrustServerCertificate=True"))
            {
                con.Open();
                string query = "INSERT INTO [Order] (Ord_Id, Date, Price_item, Item_Id, Category, Quantity, Total_Amount) VALUES (@Ord_Id, @Date, @Price_item, @Item_Id, @Category, @Quantity, @Total_Amount)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    string selectedCategory = comboBox1.SelectedItem.ToString();
                    int selectedQuantity = int.Parse(comboBox2.SelectedItem.ToString());
                    DateTime selectedDate = dateTimePicker1.Value;

                    cmd.Parameters.AddWithValue("@Ord_Id", int.Parse(textBox1.Text));
                    cmd.Parameters.AddWithValue("@Date", selectedDate);
                    cmd.Parameters.AddWithValue("@Price_item", decimal.Parse(textBox2.Text));
                    cmd.Parameters.AddWithValue("@Item_Id", int.Parse(textBox3.Text));
                    cmd.Parameters.AddWithValue("@Category", selectedCategory);
                    cmd.Parameters.AddWithValue("@Quantity", selectedQuantity);
                    cmd.Parameters.AddWithValue("@Total_Amount", decimal.Parse(textBox4.Text));
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Inserted Successfully", "Success", MessageBoxButtons.OK);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-1VNNIKF\\SQLEXPRESS01;Initial Catalog=CoffeeShop;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Item", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox2.Text, out int price) &&
              int.TryParse(comboBox2.Text, out int quantity))
            {
                int totalAmount = price * quantity;
                textBox4.Text = totalAmount.ToString();
            }
            else
            {
                textBox4.Text = string.Empty;
            }
        }

        private void textBox3_KeyUp(object sender, KeyEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-1VNNIKF\\SQLEXPRESS01;Initial Catalog=CoffeeShop;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Item where Item_Id= '" + textBox3.Text + "'", con);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    // Fetch the data from the reader and display it in the TextBox
                    textBox2.Text = reader["Price"].ToString();
                    // CalculateTotalAmount();

                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*SqlConnection con = new SqlConnection("Data Source=DESKTOP-1VNNIKF\\SQLEXPRESS01;Initial Catalog=CoffeeShop;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("update Order set  Ord_Id=@Ord_Id, Date=@Date, Price_item=@Price_item, Item_Id=@Item_Id, Category=@Category, Quantity=@Quantity, Total_Amount=@Total_Amount where Ord_Id=@Ord_Id", con);
            string selectedCategory = comboBox1.SelectedItem.ToString();
            int selectedQuantity = int.Parse(comboBox2.SelectedItem.ToString());
            DateTime selectedDate = dateTimePicker1.Value;
            cmd.Parameters.AddWithValue("@Ord_Id", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Date", selectedDate);
            cmd.Parameters.AddWithValue("@Price_item", decimal.Parse(textBox2.Text));
            cmd.Parameters.AddWithValue("@Item_Id", int.Parse(textBox3.Text));
            cmd.Parameters.AddWithValue("@Category", selectedCategory);
            cmd.Parameters.AddWithValue("@Quantity", selectedQuantity);
            cmd.Parameters.AddWithValue("@Total_Amount", decimal.Parse(textBox4.Text));
            cmd.ExecuteNonQuery();
            con.Close();*/
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-1VNNIKF\\SQLEXPRESS01;Initial Catalog=CoffeeShop;Integrated Security=True;TrustServerCertificate=True"))
            {
                con.Open();
                string query = "UPDATE [Order] SET Date = @Date, Price_item = @Price_item, Item_Id = @Item_Id, Category = @Category, Quantity = @Quantity, Total_Amount = @Total_Amount WHERE Ord_Id = @Ord_Id";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    string selectedCategory = comboBox1.SelectedItem.ToString();
                    int selectedQuantity = int.Parse(comboBox2.SelectedItem.ToString());
                    DateTime selectedDate = dateTimePicker1.Value;

                    cmd.Parameters.AddWithValue("@Ord_Id", int.Parse(textBox1.Text));
                    cmd.Parameters.AddWithValue("@Date", selectedDate);
                    cmd.Parameters.AddWithValue("@Price_item", decimal.Parse(textBox2.Text));
                    cmd.Parameters.AddWithValue("@Item_Id", int.Parse(textBox3.Text));
                    cmd.Parameters.AddWithValue("@Category", selectedCategory);
                    cmd.Parameters.AddWithValue("@Quantity", selectedQuantity);
                    cmd.Parameters.AddWithValue("@Total_Amount", int.Parse(textBox4.Text));
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Updated Successfully", "Success", MessageBoxButtons.OK);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*SqlConnection con = new SqlConnection("Data Source=DESKTOP-1VNNIKF\\SQLEXPRESS01;Initial Catalog=CoffeeShop;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete Order where Ord_Id=@Ord_Id", con);
            cmd.Parameters.AddWithValue("@Ord_Id", textBox1.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Deleted Successfully", "Success", MessageBoxButtons.OK);*/
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-1VNNIKF\\SQLEXPRESS01;Initial Catalog=CoffeeShop;Integrated Security=True;TrustServerCertificate=True"))
            {
                con.Open();
                string query = "DELETE FROM [Order] WHERE Ord_Id = @Ord_Id";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Ord_Id", int.Parse(textBox1.Text));
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Deleted Successfully", "Success", MessageBoxButtons.OK);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            /* if (textBox1.Text == "")
             {
                 SqlConnection con = new SqlConnection("Data Source=DESKTOP-1VNNIKF\\SQLEXPRESS01;Initial Catalog=CoffeeShop;Integrated Security=True;TrustServerCertificate=True");
                 con.Open();
                 SqlCommand cmd = new SqlCommand("Select * from Order", con);
                 SqlDataAdapter da = new SqlDataAdapter(cmd);
                 DataTable dt = new DataTable();
                 da.Fill(dt);
                 dataGridView1.DataSource = dt;
             }
             else if (textBox1.Text != "")
             {
                 SqlConnection con = new SqlConnection("Data Source=DESKTOP-1VNNIKF\\SQLEXPRESS01;Initial Catalog=CoffeeShop;Integrated Security=True;TrustServerCertificate=True");
                 con.Open();
                 SqlCommand cmd = new SqlCommand("Select * from Order where Ord_Id= '" + textBox1.Text + "'", con);
                 // cmd.Parameters.AddWithValue("@Name", name_textBox1);
                 SqlDataAdapter da = new SqlDataAdapter(cmd);
                 DataTable dt = new DataTable();
                 da.Fill(dt);
                 dataGridView1.DataSource = dt;
             }*/
            string connectionString = "Data Source=DESKTOP-1VNNIKF\\SQLEXPRESS01;Initial Catalog=CoffeeShop;Integrated Security=True;TrustServerCertificate=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd;

                if (textBox1.Text == "")
                {
                    cmd = new SqlCommand("SELECT * FROM [Order]", con);
                }
                else
                {
                    cmd = new SqlCommand("SELECT * FROM [Order] WHERE Ord_Id = @Ord_Id", con);
                    cmd.Parameters.AddWithValue("@Ord_Id", int.Parse(textBox1.Text));
                }

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
