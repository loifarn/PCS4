using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment6
{
    public partial class Form1 : Form
    {
        private BinaryTree _tree;
        public Form1()
        {
            InitializeComponent();
            _tree = new BinaryTree();
            _tree.Root = new Node("TrondBjarne");
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                _tree.Root.Add(TB_Input.Text);
                Label_Add.Text = $"Added: {TB_Input.Text}";
                
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please enter some data before adding!");
            }
            catch (Exception)
            {
                MessageBox.Show("An error has occured.");
            }
        }

        private void Btn_Find_Click(object sender, EventArgs e)
        {
            try
            {
                if (_tree.Root.Find(_tree.Root, TB_Input.Text) )
                {
                    MessageBox.Show("Node exists");
                }
                else
                {
                    MessageBox.Show("Node does not exist");
                }
            }
            catch
            {
                MessageBox.Show("An error has occured");
            }
        }

        private void Btn_Show_Click(object sender, EventArgs e)
        {
            try
            {
                List<Node> list = new List<Node>();
                _tree.Root.Show(list, _tree.Root);
                LB_Output.Items.Clear();

                foreach(Node n in list)
                {
                    LB_Output.Items.Add(n.Value);
                }
            }
            catch
            {
                MessageBox.Show("An error has occured");
            }
        }

        private void Btn_Count_Click(object sender, EventArgs e)
        {
            try
            {
                int value = _tree.Root.Count(_tree.Root);
                Label_Count.Text = $"count: {value}";
            }
            catch
            {
                MessageBox.Show("An error has occured");
            }
        }

        private void Btn_Test_Click(object sender, EventArgs e)
        {
            string one = "one";
            string two = "two";

            TB_Input.Text = two.CompareTo(one).ToString();
        }

        private void Btn_Preorder_Click(object sender, EventArgs e)
        {
            try
            {
                List<Node> list = new List<Node>();
                _tree.Root.PreOrder(list, _tree.Root);
                LB_Output.Items.Clear();

                foreach (Node n in list)
                {
                    LB_Output.Items.Add(n.Value);
                }
            }
            catch
            {
                MessageBox.Show("An error has occured");
            }
        }

        private void Btn_Postorder_Click(object sender, EventArgs e)
        {
            try
            {
                List<Node> list = new List<Node>();
                _tree.Root.PostOrder(list, _tree.Root);
                LB_Output.Items.Clear();

                foreach (Node n in list)
                {
                    LB_Output.Items.Add(n.Value);
                }
            }
            catch
            {
                MessageBox.Show("An error has occured");
            }
        }

        private void Btn_Inorder_Click(object sender, EventArgs e)
        {
            try
            {
                List<Node> list = new List<Node>();
                _tree.Root.InOrder(list, _tree.Root);
                LB_Output.Items.Clear();

                foreach (Node n in list)
                {
                    LB_Output.Items.Add(n.Value);
                }
            }
            catch
            {
                MessageBox.Show("An error has occured");
            }
        }

        private void Btn_Height_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_tree.Root.Height(_tree.Root).ToString());
        }

        //doesnt work.
        private void Btn_Parent_Click(object sender, EventArgs e)
        {
            Node result = _tree.Root.FindParent(_tree.Root, new Node(TB_Input.Text));

            if(result == null)
            {
                MessageBox.Show($"null");
            }
            else
            {
                MessageBox.Show($"Parent: {result.Value}");
            }
        }
    }
}
