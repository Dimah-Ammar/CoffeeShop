using System.Diagnostics;
namespace CoffeeShop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int imageno = 1;

        private void loadimage()
        {
            if (imageno == 4)
            {
                imageno = 1;
            }
            pictureBox2.ImageLocation = string.Format(@"images\{0}.jpg", imageno);
            imageno++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu m1 = new Menu();
            m1.Show();
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AboutUs a1 = new AboutUs();
            a1.Show();
            Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Contact c1 = new Contact();
            c1.Show();
            Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
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

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://twitter.com/login");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.instagram.com/thecoffeehouse.pk/");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://facebook.com/thecoffeehouse.pk");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //loadimage();
            if (pictureBox2.Visible == true)
            {
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
            }
            else if (pictureBox3.Visible == true)
            {
                pictureBox3.Visible = false;
                pictureBox4.Visible = true;
            }
            else if (pictureBox4.Visible == true)
            {
                pictureBox4.Visible = false;
                pictureBox5.Visible = true;
            }
            else if (pictureBox5.Visible == true)
            {
                pictureBox5.Visible = false;
                pictureBox1.Visible = true;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
