using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
namespace CoffeeShop
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
            comboBox1.Items.Add("Male");
            comboBox1.Items.Add("Female");
            comboBox2.Items.Add("Admin");
            comboBox2.Items.Add("User");

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 f2 = new Form2();
            f2.Show();
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text == "User")
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-1VNNIKF\\SQLEXPRESS01;Initial Catalog=CoffeeShop;Integrated Security=True;TrustServerCertificate=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into USignup values(@Name, @Password, @Address, @Email, @Phone, @Gender)", con);
                string selectedGender = comboBox1.SelectedItem.ToString();
                cmd.Parameters.AddWithValue("@Name", textBox1.Text);
                cmd.Parameters.AddWithValue("@Password", textBox2.Text);
                cmd.Parameters.AddWithValue("@Address", textBox3.Text);
                cmd.Parameters.AddWithValue("@Email", textBox4.Text);
                cmd.Parameters.AddWithValue("@Phone", int.Parse(textBox5.Text));
                cmd.Parameters.AddWithValue("@Gender", selectedGender);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Registered Successfully");
                MessageBox.Show("Please Login for Access");
                Log l1 = new Log();
                l1.Show();
                Visible = false;
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-1VNNIKF\\SQLEXPRESS01;Initial Catalog=CoffeeShop;Integrated Security=True;TrustServerCertificate=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into AdSignup values( @Adm_Id, @Name, @Password, @Address, @Email, @Phone, @Gender, @Designation)", con);
                string selectedGender = comboBox1.SelectedItem.ToString();
                cmd.Parameters.AddWithValue("@Name", textBox1.Text);
                cmd.Parameters.AddWithValue("@Password", textBox2.Text);
                cmd.Parameters.AddWithValue("@Address", textBox3.Text);
                cmd.Parameters.AddWithValue("@Email", textBox4.Text);
                cmd.Parameters.AddWithValue("@Phone", int.Parse(textBox5.Text));
                cmd.Parameters.AddWithValue("@Gender", selectedGender);
                cmd.Parameters.AddWithValue("@Adm_Id", int.Parse(textBox6.Text));
                cmd.Parameters.AddWithValue("@Designation", textBox7.Text);

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Registered Successfully");
                MessageBox.Show("Please Login for Access");
                Log l1 = new Log();
                l1.Show();
                Visible = false;
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        /* private void button7_Click(object sender, EventArgs e)
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
         }*/
    }
}
