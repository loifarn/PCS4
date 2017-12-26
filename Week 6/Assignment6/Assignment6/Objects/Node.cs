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

        public void Insert(string person)
        {
            if (Value.CompareTo(person) == 1)
            {
                if(Left == null)
                {
                    Left = new Node(person);
                }
                else
                {
                    Left.Insert(person);
                }
            }
            else if (person.CompareTo(Value) == 1)
            {
                if(Right == null)
                {
                    Right = new Node(person);
                }
                else
                {
                    Right.Insert(person);
                }
            }
            else
            {
                Right.Insert(person);
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

        public bool Find(Node root, string Person)
        {
            if (root == null)
            {
                return false;
            }
            if (root.Value.Equals(Person))
            {
                return true;
            }

            if (root.Value.CompareTo(Person) == 1)
            {
                return Find(root.Left, Person);
            }
            else
            {
                return Find(root.Right, Person);
            }
        }

        public void Traverse(Node node)
        {
            if (node == null)
            {
                return;
            }

            Traverse(node.Left);
            Traverse(node.Right);
        }

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
    }
}
