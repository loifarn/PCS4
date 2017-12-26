using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    class Node
    {
        public string Value { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
        public Node (string value)
        {
            Value = value;
            Left = Right = null;
        }

        //Basic functionality
        public void Add(string person)
        {
            //If person is less than or equal to value, go left.
            if (person.CompareTo(Value) <= 0)
            {
                if (Left == null)
                {
                    Left = new Node(person);
                }
                else
                {
                    Left.Add(person);
                }
            }
            //If person is greater value, go right.
            else if (person.CompareTo(Value) == 1)
            {
                if (Right == null)
                {
                    Right = new Node(person);
                }
                else
                {
                    Right.Add(person);
                }
            }
            else
            {
                Right.Add(person);
            }
        }
        public int Count(Node node)
        {
            int count = 1;

            if(node.Right != null)
            {
                count += Count(node.Right);
            }
            if (node.Left != null)
            {
                count += Count(node.Left);
            }

            return count;
        }
        public bool Find(Node root, string person)
        {
            if (root == null)
            {
                return false;
            }
            if (root.Value.Equals(person))
            {
                return true;
            }

            if (person.CompareTo(root.Value) == 1)
            {
                return Find(root.Right, person);
            }
            else
            {
                return Find(root.Left, person);
            }
        }

        //Show content
        public void Show(List<Node> list, Node node)
        {
            if(node == null)
            {
                list = null;
                return;
            }
            else
            {
                list.Add(node);
            }
            Show(list, node.Right);
            Show(list, node.Left);
        }

        //Sorting
        public void PreOrder(List<Node> list, Node node)
        {
            if (node != null)
            {
                list.Add(node);
                PreOrder(list, node.Left);
                PreOrder(list, node.Right);
            }
        }
        public void InOrder(List<Node> list, Node node)
        {
            if (node != null)
            {
                InOrder(list, node.Left);
                list.Add(node);
                InOrder(list, node.Right);
            }
        }
        public void PostOrder(List<Node> list, Node node)
        {
            if (node != null)
            {
                PostOrder(list, node.Left);
                PostOrder(list, node.Right);
                list.Add(node);
            }
        }

        //Extra
        public int Height(Node node)
        {
            if (node == null)
            {
                return -1;
            }

            int leftHeight = Height(node.Left);
            int rightHeight = Height(node.Right);

            if (leftHeight > rightHeight)
            {
                return leftHeight + 1;
            }
            else
            {
                return rightHeight + 1;
            }

        }
        public int Longest(Node node)
        {
            List<Node> NodeList = new List<Node>();
            List<String> StringList = new List<string>();
            String Longest = "";

            foreach(Node n in NodeList)
            {
                StringList.Add(n.Value);
            }
            foreach(String s in StringList)
            {
                if (Longest.Equals(""))
                {
                    Longest = s;
                }
                else if (Longest.Length < s.Length)
                {
                    Longest = s;
                }
            }

            return Longest.Length;
        }
        public int Shortest(Node node)
        {
            List<Node> NodeList = new List<Node>();
            List<String> StringList = new List<string>();
            String Shortest = "";

            foreach (Node n in NodeList)
            {
                StringList.Add(n.Value);
            }
            foreach (String s in StringList)
            {
                if (Shortest.Equals(""))
                {
                    Shortest = s;
                }
                else if (Shortest.Length > s.Length)
                {
                    Shortest = s;
                }
            }

            return Shortest.Length;
        }

        //Returns parent node
        public Node FindParent(Node root, Node child)
        {
            // Base Cases
            if (root.Left == null && root.Right == null)
                return null;

            if (root.Left == child || root.Right == child)
                return root;

            // Recursion
            var leftSearch = FindParent(root.Left, child);
            if (leftSearch != null)
            {
                return leftSearch;
            }
            else
            {
                return FindParent(root.Right, child);
            }
        }
    }
}
