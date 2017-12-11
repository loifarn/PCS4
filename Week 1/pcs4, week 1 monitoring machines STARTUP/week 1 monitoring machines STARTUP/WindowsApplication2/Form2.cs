using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsApplication2.StringManipulator;

namespace WindowsApplication2
{
    public partial class Form2 : Form
    {

        private StringManipulator sm;

        public Form2()
        {
            InitializeComponent();
            sm = new StringManipulator();
        }

        private void btn_changestring_Click(object sender, EventArgs e)
        {

            if(rb_tocapitals.Checked)
            {
                sm.manipulatorHandler = new StringManipulatorHandler(sm.ToCapital);
            }
            else if (rb_nextchar.Checked)
            {
                sm.manipulatorHandler = new StringManipulatorHandler(sm.ToNextchar);
            }
            else if (rb_formerchar.Checked)
            {
                sm.manipulatorHandler = new StringManipulatorHandler(sm.ToFormerChar);
            }
            else if (rb_towhat.Checked)
            {
                sm.manipulatorHandler = new StringManipulatorHandler(sm.ToWhat);
            }
            else
            {
                MessageBox.Show("No radio button selected.");
            }
            tb_output.Text = sm.manipulatorHandler(tb_input.Text);
        }
    }
}
