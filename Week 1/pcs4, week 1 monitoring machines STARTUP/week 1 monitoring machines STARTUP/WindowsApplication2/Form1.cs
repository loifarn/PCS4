using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using static WindowsApplication2.Machine;

namespace WindowsApplication2
{
    public partial class Form1 : Form
    {
        private ManufacturingCompany mc;
        private bool loggingState;
        public Form1()
        {
            InitializeComponent();
            mc = new ManufacturingCompany("VDL assembling Mini Cooper");
            loggingState = false;
        }

        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            lbInfo.Items.Clear();
            lbInfo.Items.Add(mc.ToString());
            lbInfo.Items.Add("");
            foreach (Machine m in mc.Machines)
            {
                lbInfo.Items.Add(m.ToString());
            }
        }

        private void btnAddMachine_Click(object sender, EventArgs e)
        {
            try
            {
                Machine m = new Machine(tbMachineName.Text, Convert.ToInt32(tbTemp.Text), Convert.ToInt32(tbPressure.Text));
                m.stateHandler += CriticalStateReached;

                if (mc.AddMachine(m))
                {
                    MessageBox.Show("Successfully added");
                }
                else
                {
                    MessageBox.Show("We already have a machine with that name");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please fill in some numbers for temperature and pressure");
            }

        }

        private void btnSimulateTemperature_Click(object sender, EventArgs e)
        {
            try
            {
                Machine m = mc.GetMachine(tbMachineName.Text);
                if (m != null)
                {
                    m.SetTemperature(Convert.ToInt32(tbTemp.Text));
                }
                else
                {
                    MessageBox.Show("We do not have a machine with this name");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please fill in a number for temperature");
            }
        }

        private void btnSimulatePressure_Click(object sender, EventArgs e)
        {
            try
            {
                Machine m = mc.GetMachine(tbMachineName.Text);
                if (m != null)
                {
                    m.SetPressure(Convert.ToInt32(tbPressure.Text));
                }
                else
                {
                    MessageBox.Show("We do not have a machine with this name");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please fill in a number for temperature");
            }
        }

        private void btnLogging_Click(object sender, EventArgs e)
        {
            Machine m = mc.GetMachine(tbMachineName.Text);
            if (m != null && loggingState == false)
            {
                loggingState = true;
                m.stateHandler += LogCriticalState;
                MessageBox.Show($"Logging state is now active");
            }
            else if (loggingState == true)
            {
                loggingState = false;
                m.stateHandler -= LogCriticalState;
                MessageBox.Show($"Logging state is now inactive");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //todo
        }
        
        private void btnLoad_Click(object sender, EventArgs e)
        {
            //todo
        }

        private void CriticalStateReached(Machine sender, string reason)
        {
            lbWarnings.Items.Add($"{sender.Name}, Error:{reason}");
        }

        private void LogCriticalState(Machine sender, string reason)
        {
            string filepath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\logging.txt";

            using (FileStream fw = new FileStream(filepath, FileMode.Append, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fw))
                {
                    sw.WriteLine($"Error on machine: {sender.Name} | Errortype: {reason} | Time: {DateTime.Now}");
                }
            }
    
        }
    }
}