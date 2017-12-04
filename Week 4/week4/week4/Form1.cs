using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Calculate_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(tb_a.Text);
            int b = Convert.ToInt32(tb_b.Text);
            int product;

            Assignment4_1 assignment = new Assignment4_1();
            assignment.CalculateProduct(a, b, out product);

            tb_product.Text = product.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(tb_numa.Text);
            int b = Convert.ToInt32(tb_numb.Text);

            Assignment4_2 assignment = new Assignment4_2();
            assignment.Swap(ref a, ref b);

            tb_numa.Text = a.ToString();
            tb_numb.Text = b.ToString();
        }
    }
}
