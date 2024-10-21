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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace CoffeeShop
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
            comboBox1.Items.Add("Male");
            comboBox1.Items.Add("Female");

        }

        private void Employee_Load(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-1VNNIKF\\SQLEXPRESS01;Initial Catalog=CoffeeShop;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete AdSignup where Adm_Id=@Adm_Id", con);
            //cmd.Parameters.AddWithValue("@Name", name_textBox1.Text);
            cmd.Parameters.AddWithValue("@Adm_Id", int.Parse(adm_id_textBox7.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Deleted Successfully", "Success", MessageBoxButtons.OK);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /* SqlConnection con = new SqlConnection("Data Source=DESKTOP-1VNNIKF\\SQLEXPRESS01;Initial Catalog=CoffeeShop;Integrated Security=True;TrustServerCertificate=True");
             con.Open();*/
            if (adm_id_textBox7.Text == "")
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-1VNNIKF\\SQLEXPRESS01;Initial Catalog=CoffeeShop;Integrated Security=True;TrustServerCertificate=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from AdSignup", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (adm_id_textBox7.Text != "")
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-1VNNIKF\\SQLEXPRESS01;Initial Catalog=CoffeeShop;Integrated Security=True;TrustServerCertificate=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from AdSignup where Adm_Id= '" + adm_id_textBox7.Text + "'", con);
                //cmd.Parameters.AddWithValue("@Name", name_textBox1);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-1VNNIKF\\SQLEXPRESS01;Initial Catalog=CoffeeShop;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("update AdSignup set Adm_Id=@Adm_Id, Name=@Name, Password=@Password, Address=@Address, Email=@Email, Phone=@Phone, Gender=@Gender, Designation=@Designation where Adm_Id=@Adm_Id", con);
            string selectedGender = comboBox1.SelectedItem.ToString();
            cmd.Parameters.AddWithValue("@Name", name_textBox1.Text);
            cmd.Parameters.AddWithValue("@Password", password_textBox2.Text);
            cmd.Parameters.AddWithValue("@Address", address_textBox3.Text);
            cmd.Parameters.AddWithValue("@Email", email_textBox4.Text);
            cmd.Parameters.AddWithValue("@Phone", int.Parse(phone_textBox5.Text));
            cmd.Parameters.AddWithValue("@Gender", selectedGender);
            cmd.Parameters.AddWithValue("@Designation", designation_textBox6.Text);
            cmd.Parameters.AddWithValue("@Adm_Id", int.Parse(adm_id_textBox7.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated Successfully", "Success", MessageBoxButtons.OK);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Dashboard d1 = new Dashboard();
            d1.Show();
            Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-1VNNIKF\\SQLEXPRESS01;Initial Catalog=CoffeeShop;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into AdSignup values(@Adm_Id, @Name, @Password, @Address, @Email, @Phone, @Gender, @Designation)", con);
            string selectedGender = comboBox1.SelectedItem.ToString();
            cmd.Parameters.AddWithValue("@Name", name_textBox1.Text);
            cmd.Parameters.AddWithValue("@Password", password_textBox2.Text);
            cmd.Parameters.AddWithValue("@Address", address_textBox3.Text);
            cmd.Parameters.AddWithValue("@Email", email_textBox4.Text);
            cmd.Parameters.AddWithValue("@Phone", int.Parse(phone_textBox5.Text));
            cmd.Parameters.AddWithValue("@Gender", selectedGender);
            cmd.Parameters.AddWithValue("@Designation", designation_textBox6.Text);
            cmd.Parameters.AddWithValue("@Adm_Id", int.Parse(adm_id_textBox7.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Inserted Successfully", "Success", MessageBoxButtons.OK);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            name_textBox1.Text = "";
            password_textBox2.Text = "";
            address_textBox3.Text = "";
            email_textBox4.Text = "";
            phone_textBox5.Text = "";
            designation_textBox6.Text = "";
            adm_id_textBox7.Text = "";
        }

        private void adm_id_textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
