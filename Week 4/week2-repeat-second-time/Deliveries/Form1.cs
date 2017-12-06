using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deliveries
{
    public partial class Form1 : Form
    {
        TransportCompany tc;
        public Form1()
        {
            InitializeComponent();
            tc = new TransportCompany();
        }

        private void btLoad_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.ShowDialog();
                    if(!(ofd is null))
                    {
                        tc.LoadPersonsFromFile(ofd.FileName);
                    }
                        
                    ofd.ShowDialog();
                    if (!(ofd is null))
                    {
                        tc.LoadDeliverablesFromFile(ofd.FileName);
                    }
                    MessageBox.Show("Success!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Something went wrong when loading the files" + ex.Message);
                
            }
        }

        private void btSortByWeight_Click(object sender, EventArgs e)
        {
            tc.SortByWeight();
            listBox1.DataSource = null;
            listBox1.DataSource = tc.Deliverables;
        }

        private void btSortByName_Click(object sender, EventArgs e)
        {
            tc.SortByName();
            listBox1.DataSource = null;
            listBox1.DataSource = tc.Deliverables;
        }

        private void btSortById_Click(object sender, EventArgs e)
        {
            tc.SortById();
            listBox1.DataSource = null;
            listBox1.DataSource = tc.Deliverables;
        }

        private void btSortByAddress_Click(object sender, EventArgs e)
        {
            tc.SortByAddress();
            listBox1.DataSource = null;
            listBox1.DataSource = tc.Deliverables;
        }

        private void btSortForPostman_Click(object sender, EventArgs e)
        {
            tc.SortForPostman();
            listBox1.DataSource = tc.Deliverables;
        }

        private void Btn_SearchID_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.Items.Clear();

            //p1
            /*
            var result = tc.FindDeliverable(Convert.ToInt32(tb_search.Text));
            if (result != null)
            {
                listBox1.Items.Add(result);
            }
            */
            //p2

            var result = BinarySearchById(Convert.ToInt32(tb_search.Text), 0, tc.Deliverables.Count - 1);
            if (result != null)
            {
                listBox1.Items.Add(result);
            }

        }

        public Deliverable BinarySearchById(int id, int lowindex, int highindex)
        {
            int m;

            //Sort by ID first
            tc.SortById();

            while (lowindex <= highindex)
            {
                m = (lowindex + highindex) / 2;

                if (id == m)
                {
                    //ID is middle value
                    return tc.Deliverables[m+1];
                }
                else if (id > m)
                {
                    //ID is bigger than value
                    lowindex = m + 1;
                    BinarySearchById(id, lowindex, highindex);
                }
                else
                {
                    //ID is smaller than value
                    highindex = m - 1;
                    BinarySearchById(id, lowindex, highindex);
                }
            }
            return null;
        }
    }
}
