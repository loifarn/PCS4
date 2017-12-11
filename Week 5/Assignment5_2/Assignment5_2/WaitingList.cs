using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5_2
{
    class WaitingList
    {
        public delegate void FiveOrBigger();
        public event FiveOrBigger fiveOrBigger;

        private Node firstNode;
        private Node lastNode;

        public WaitingList()
        {
            firstNode = null;
            lastNode = null;
        }

        public void Add(Patient p)
        {
            Node newNode = new Node(p);
            if(firstNode == null)
            {
                firstNode = newNode;
                lastNode = newNode;
            }
            else
            {
                newNode.Next = firstNode;
                firstNode = newNode;

                if (Count() >= 5)
                {
                    fiveOrBigger(); //#Triggered
                }
            }
        }
        public string Show()
        {
            if (Count() <= 0)
            {
                return "No patients added\n";
            }
            else
            {
                string s = "";
                for (Node n = firstNode; n.Next != null; n = n.Next)
                {
                    s += $"Name:{n.Patient.Name}, Reason:{n.Patient.Reason}, Doctor: {n.Patient.Doctor}\n";
                }
                return s;
            }
        }
        public void Remove(Node node)
        {
            if (firstNode == null)
                return;

            if (firstNode == node)
            {
                firstNode = firstNode.Next;
            }
            else
            {
                Node previous = firstNode;
                Node current = firstNode.Next;

                while (current != null)
                {
                    if (current.Next == node)
                    {
                        previous.Next = current.Next;
                        break;
                    }

                    previous = current;
                    current = current.Next;
                }
            }
        }
        public int Count()
        {
            int count = 0;
            if(firstNode == null)
            {
                return -1;
            }
            else
            {
                for (Node n = firstNode; n.Next != null; n = n.Next)
                {
                    count++;
                }
                return count;
            }
        }
        public int Count(string Doctor)
        {
            int count = 0;
            if (firstNode == null)
            {
                return -1;
            }
            else
            {
                for (Node n = firstNode; n.Next != null; n = n.Next)
                {
                    if(n.Patient.Doctor.Equals(Doctor))
                    {
                        count++;
                    }
                }
                return count;
            }
        }
        public string NextPatient(string Doctor)
        {
            string nextPatient = null;
            if(firstNode == null)
            {
                return "No patients left! Time for a break!";
            } 
            else
            {
                for(Node n = firstNode; n.Next != null; n = n.Next)
                {
                    if (n.Patient.Doctor.Equals(Doctor) || n.Patient.Doctor.Equals("No Preference"))
                    {
                        if(nextPatient == null)
                        {
                            nextPatient = n.Patient.Name;
                            Remove(n);//Moving person out of waiting list.
                        }
                    }
                }
                return nextPatient;
            }
        }

    }
}
