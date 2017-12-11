using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_2
{
    class Node
    {
        public Patient Patient  { get; set; }
        public Node Next { get; set; }

        public Node(Patient p)
        {
            Patient = p;
            Next = null;
        }
    }
}
