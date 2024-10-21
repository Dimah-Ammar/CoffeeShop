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
    public partial class Coffee : Form
    {
        public Coffee()
        {
            InitializeComponent();
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

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu m2 = new Menu();
            m2.Show();
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Order o1 = new Order();
            o1.Show();
            Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
