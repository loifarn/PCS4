using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5_2
{
    public partial class Assignment5_2_Form : Form
    {
        WaitingList waitingList = new WaitingList();
        public Assignment5_2_Form()
        {
            InitializeComponent();
        }

        private void Btn_Register_Click(object sender, EventArgs e)
        {
            waitingList.Add(new Patient(TB_Name.Text, TB_Reason.Text));
        }

        public void WR_Limit_reached()
        {
            GB_WaitingRoom.Text = waitingList.ShowFive();
        }
    }
}
