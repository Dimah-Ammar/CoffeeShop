using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CoffeeShop
{
    public partial class Log : Form
    {
        public Log()
        {
            InitializeComponent();
            comboBox1.Items.Add("Admin");
            comboBox1.Items.Add("User");

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Signup s1 = new Signup();
            s1.Show();
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            name_textBox1.Text = "";
            password_textBox2.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "User")
            {
                //    int result = -1;
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-1VNNIKF\\SQLEXPRESS01;Initial Catalog=CoffeeShop;Integrated Security=True;TrustServerCertificate=True");
                string username = name_textBox1.Text;
                string password = password_textBox2.Text;
                String query = "SELECT count(*) FROM USignup where Name= @Name and Password= @Password";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Name", username);
                cmd.Parameters.AddWithValue("@Password", password);

                con.Open();
                int result = Convert.ToInt32(cmd.ExecuteScalar());
                if (result > 0)
                {
                    MessageBox.Show("LOGGED IN AS USER", "Login", MessageBoxButtons.OK);
                    Form1 f1 = new Form1();
                    f1.Show();
                    Visible = false;
                }
                else
                {
                    MessageBox.Show("Invalid user id or password", "Login", MessageBoxButtons.OK);
                }
            }
            else if (comboBox1.Text == "Admin")
            {
                //    int result = -1;
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-1VNNIKF\\SQLEXPRESS01;Initial Catalog=CoffeeShop;Integrated Security=True;TrustServerCertificate=True");
                string usernamee = name_textBox1.Text;
                string passwordd = password_textBox2.Text;
                String queryy = "SELECT count(*) FROM AdSignup where Name= @Name and Password= @Password";
                SqlCommand cmdd = new SqlCommand(queryy, conn);
                cmdd.Parameters.AddWithValue("@Name", usernamee);
                cmdd.Parameters.AddWithValue("@Password", passwordd);

                conn.Open();
                int resultt = Convert.ToInt32(cmdd.ExecuteScalar());
                if (resultt > 0)
                {
                    MessageBox.Show("LOGGED IN AS ADMIN", "Login", MessageBoxButtons.OK);
                    Dashboard d1 = new Dashboard();
                    d1.Show();
                    Visible = false;
                }
                else
                {
                    MessageBox.Show("Invalid user id or password", "Login", MessageBoxButtons.OK);
                }
            }
            /* else
             {
                 MessageBox.Show("Invalid user id or password", "Login", MessageBoxButtons.OK);
             }*/

        }
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
