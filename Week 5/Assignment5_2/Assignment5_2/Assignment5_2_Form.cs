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
            waitingList.fiveOrBigger += FiveOrBigger;

            if(Rb_John.Checked)
            {
                waitingList.Add(new Patient(TB_Name.Text, TB_Reason.Text, "John"));
            }
            else if(Rb_Carla.Checked)
            {
                waitingList.Add(new Patient(TB_Name.Text, TB_Reason.Text, "Carla"));
            }
            else if(Rb_NoPreference.Checked)
            {
                waitingList.Add(new Patient(TB_Name.Text, TB_Reason.Text, "No Preference"));
            }
            else
            {
                MessageBox.Show("Please select a preference");
            }
            UpdateLabels();
        }

        private void Btn_NextPatientJohn_Click(object sender, EventArgs e)
        {
            if(waitingList.Count() <= 0)
            {
                GB_John.Text = $"Dr. John\nNo Patiens Waiting";
            }
            else
            {
                GB_John.Text = $"Dr. John\nCurrent Patient: {waitingList.NextPatient("John")}";
                GB_WaitingRoom.Text = $"Waiting Room\n{waitingList.Show()}";

                UpdateLabels();
            }
        }

        private void Btn_NextPatientCarla_Click(object sender, EventArgs e)
        {
            if (waitingList.Count() <= 0)
            {
                GB_Carla.Text = $"Dr. Carla\nNo Patiens Waiting";
            }
            else
            {
                GB_Carla.Text = $"Dr. Carla\nCurrent Patient: {waitingList.NextPatient("Carla")}";
                GB_WaitingRoom.Text = $"Waiting Room\n{waitingList.Show()}";

                UpdateLabels();
            }
        }

        //Events
        public void FiveOrBigger()
        {
            if (waitingList.Count() >= 5)
            {
                GB_WaitingRoom.Text = $"Waiting Room\n{waitingList.Show()}";
            }
        }

        public void UpdateLabels()
        {
            Label_TotalWaiting.Text = $"in waiting room: {waitingList.Count().ToString()}";
            Label_JohnPref.Text = $"Waiting for John: {waitingList.Count("John").ToString()}";
            Label_CarlaPref.Text = $"Waiting for Carla: {waitingList.Count("Carla").ToString()}";
            Label_CNoPref.Text = $"No Preference: {waitingList.Count("No Preference").ToString()}";
            Label_JNoPref.Text = Label_CNoPref.Text;
        }
    }
}
