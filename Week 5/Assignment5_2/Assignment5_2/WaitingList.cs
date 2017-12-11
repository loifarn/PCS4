using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_2
{
    class WaitingList
    {
        public delegate void WaitingRoomHandler(WaitingList wl);
        public event WaitingRoomHandler waitingRoomHandler;

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
                    waitingRoomHandler(this);
                }
            }
        }

        public string ShowFive() //does not work if list is empthy.
        {
            string s = "";
            int count = 0;
            for (Node n = firstNode; n.Next != null; n = n.Next)
            {
                while(count < 5)
                {
                    s += $"Name:{n.Patient.Name}, Reason:{n.Patient.Reason}\n";
                    count++;
                }
            }
            return s;
        }

        public int Count() //does not work if list is empthy.
        {
            int count = 0;
            for (Node n = firstNode; n.Next != null; n = n.Next)
            {
                count++;
            }
            return count;
        }
    }
}
