using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomeRecursiveMethods
{
    public partial class Form1 : Form
    {
        MyMethods methods;
        public Form1()
        {
            InitializeComponent();
            methods = new MyMethods();
        }

        private void Btn_SumSquares_Click(object sender, EventArgs e)
        {
            output.Text = methods.sumSquares(Convert.ToInt32(input.Text)).ToString();
        }

        private void Btn_SumArray_Click(object sender, EventArgs e)
        {
            int[] testArray =
            {
                5, 4, 3, 2, 1
            };

            output.Text = methods.sum(testArray, 5).ToString();
        }

        private void Btn_MaxInArray_Click(object sender, EventArgs e)
        {
            int[] testArray =
{
                5, 4, 3, 2, 9
            };

            output.Text = methods.max(testArray, 4).ToString();
        }

        private void Btn_SumOfDigits_Click(object sender, EventArgs e)
        {
            output.Text = methods.sumOfDigits(Convert.ToInt32(input.Text)).ToString();
        }

        //There are more methods to be written but I think i got the gist of it. .. . 
    }
}
