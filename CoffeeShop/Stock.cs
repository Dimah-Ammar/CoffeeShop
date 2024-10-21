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
    public partial class Stock : Form
    {
        public Stock()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-1VNNIKF\\SQLEXPRESS01;Initial Catalog=CoffeeShop;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Stock values(@St_Id, @Name, @Quantity)", con);
            cmd.Parameters.AddWithValue("@St_Id", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@Quantity", int.Parse(textBox3.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Inserted Successfully", "Success", MessageBoxButtons.OK);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /* SqlConnection con = new SqlConnection("Data Source=DESKTOP-1VNNIKF\\SQLEXPRESS01;Initial Catalog=CoffeeShop;Integrated Security=True;TrustServerCertificate=True");
             con.Open();
             SqlCommand cmd = new SqlCommand("update Stock set  St_Id=@St_Id, Name=@Name, Quantity=@Quantity where St_Id=@St_Id", con);
             cmd.Parameters.AddWithValue("@St_Id", int.Parse(textBox1.Text));
             cmd.Parameters.AddWithValue("@_Name", textBox2.Text);
             cmd.Parameters.AddWithValue("@Quantity", int.Parse(textBox3.Text));
             cmd.ExecuteNonQuery();
             con.Close();*/
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-1VNNIKF\\SQLEXPRESS01;Initial Catalog=CoffeeShop;Integrated Security=True;TrustServerCertificate=True"))
            {
                con.Open();
                string query = "UPDATE [Stock] SET  St_Id=@St_Id, Name=@Name, Quantity=@Quantity where St_Id=@St_Id";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@St_Id", int.Parse(textBox1.Text));
                    cmd.Parameters.AddWithValue("@Name", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Quantity", textBox3.Text);
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Updated Successfully", "Success", MessageBoxButtons.OK);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-1VNNIKF\\SQLEXPRESS01;Initial Catalog=CoffeeShop;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete Stock where St_Id=@St_Id", con);
            cmd.Parameters.AddWithValue("@St_Id", textBox1.Text);
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
                SqlCommand cmd = new SqlCommand("Select * from Stock", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (textBox1.Text != "")
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-1VNNIKF\\SQLEXPRESS01;Initial Catalog=CoffeeShop;Integrated Security=True;TrustServerCertificate=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from Stock where St_Id= '" + textBox1.Text + "'", con);
                // cmd.Parameters.AddWithValue("@Name", name_textBox1);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void button8_Click(object sender, EventArgs e)
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

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
