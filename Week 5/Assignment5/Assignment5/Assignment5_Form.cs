using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5
{
    public partial class Assignment5_Form : Form
    {
        LinkedList<String> myList;
        public Assignment5_Form()
        {
            InitializeComponent();
            //Create new linked list and add a value
            myList = new LinkedList<string>();
            myList.AddFirst("Alex");
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            myList.AddFirst(TB_Input.Text);

            LB_Display.Items.Clear();

            foreach (string s in myList)
            {
                LB_Display.Items.Add(s);
            }
        }

        private void Btn_Remove_Click(object sender, EventArgs e)
        {
            myList.Remove(TB_Input.Text);

            LB_Display.Items.Clear();

            foreach (string s in myList)
            {
                LB_Display.Items.Add(s);
            }
        }

        private void Btn_Show_Click(object sender, EventArgs e)
        {
            int i = 0;

            foreach(string s in myList)
            {
                i++;
            }

            MessageBox.Show($"Number of nodes is:{i}");
        }

        private void Btn_Find_Click(object sender, EventArgs e)
        {
            int i = 0;

            foreach(string s in myList)
            {
                i++;
                if (i == Convert.ToInt32(TB_Input.Text)) { TB_Output.Text = s; }
            }
        }
    }
}
