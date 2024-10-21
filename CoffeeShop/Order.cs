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
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CoffeeShop
{
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
            comboCategory.Items.Add("Coffee");
            for (int i = 1; i <= 10; i++)
            {
                comboQuantity.Items.Add(i);
            }


        }
        DataClassesDataContext db = new DataClassesDataContext();


        private void comboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-1VNNIKF\\SQLEXPRESS01;Initial Catalog=CoffeeShop;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Item", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Price_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboQuantity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.TryParse(Price.Text, out int price) &&
               int.TryParse(comboQuantity.Text, out int quantity))
            {
                int totalAmount = price * quantity;
                Total.Text = totalAmount.ToString();
            }
            else
            {
                Total.Text = string.Empty;
            }
        }

        private void comboQuantity_ValueMemberChanged(object sender, EventArgs e)
        {

        }

        private void Order_Load(object sender, EventArgs e)
        {

        }

        private void Item_Id_KeyUp(object sender, KeyEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-1VNNIKF\\SQLEXPRESS01;Initial Catalog=CoffeeShop;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Item where Item_Id= '" + Item_Id.Text + "'", con);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    // Fetch the data from the reader and display it in the TextBox
                    Price.Text = reader["Price"].ToString();
                    // CalculateTotalAmount();

                }

            }
        }

        private void comboQuantity_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* SqlConnection con = new SqlConnection("Data Source=DESKTOP-1VNNIKF\\SQLEXPRESS01;Initial Catalog=CoffeeShop;Integrated Security=True;TrustServerCertificate=True");
             con.Open();
             SqlCommand cmd = new SqlCommand("insert into [Order] values (@Ord_Id, @Date, @Price_item, @Item_Id, @Category, @Quantity, @Total_Amount)", con);
             string selectedCategory = comboCategory.SelectedItem.ToString();
             string selectedQuantity = comboQuantity.SelectedItem.ToString();
             DateTime selectedDate = dateTimePicker1.Value;
             cmd.Parameters.AddWithValue("@Ord_Id", int.Parse(Ord_Id.Text));
             cmd.Parameters.AddWithValue("@Date", selectedDate);
             cmd.Parameters.AddWithValue("@Price_item", int.Parse(Price.Text));
             cmd.Parameters.AddWithValue("@Item_Id", int.Parse(Item_Id.Text));
             cmd.Parameters.AddWithValue("@Category", selectedCategory);
             cmd.Parameters.AddWithValue("@Quantity", selectedQuantity);
             cmd.Parameters.AddWithValue("@Total_Amount", int.Parse(Total.Text));
             cmd.ExecuteNonQuery();
             con.Close();
             MessageBox.Show("Ordered Successfully", "Success", MessageBoxButtons.OK);*/
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-1VNNIKF\\SQLEXPRESS01;Initial Catalog=CoffeeShop;Integrated Security=True;TrustServerCertificate=True"))
            {
                con.Open();
                string query = "INSERT INTO [Order] (Ord_Id, Date, Price_item, Item_Id, Category, Quantity, Total_Amount) VALUES (@Ord_Id, @Date, @Price_item, @Item_Id, @Category, @Quantity, @Total_Amount)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    string selectedCategory = comboCategory.SelectedItem.ToString();
                    int selectedQuantity = int.Parse(comboQuantity.SelectedItem.ToString());
                    DateTime selectedDate = dateTimePicker1.Value;

                    cmd.Parameters.AddWithValue("@Ord_Id", int.Parse(Ord_Id.Text));
                    cmd.Parameters.AddWithValue("@Date", selectedDate);
                    cmd.Parameters.AddWithValue("@Price_item", decimal.Parse(Price.Text));
                    cmd.Parameters.AddWithValue("@Item_Id", int.Parse(Item_Id.Text));
                    cmd.Parameters.AddWithValue("@Category", selectedCategory);
                    cmd.Parameters.AddWithValue("@Quantity", selectedQuantity);
                    cmd.Parameters.AddWithValue("@Total_Amount", int.Parse(Total.Text));

                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Ordered Successfully", "Success", MessageBoxButtons.OK);
            Payment p1 = new Payment();
            p1.Show();
            Visible = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Coffee c1 = new Coffee();
            c1.Show();
            Visible = false;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
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
            Contact c1 = new Contact();
            c1.Show();
            Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }

    internal class DataClassesDataContext
    {
        public DataClassesDataContext()
        {
        }
    }
    
}
