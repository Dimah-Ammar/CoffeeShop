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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Employee e1 = new Employee();
            e1.Show();
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer c1 = new Customer();
            c1.Show();
            Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Item i1 = new Item();
            i1.Show();
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Orders o1 = new Orders();
            o1.Show();
            Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Stock s1 = new Stock();
            s1.Show();
            Visible = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Payments p1 = new Payments();
            p1.Show();
            Visible = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
