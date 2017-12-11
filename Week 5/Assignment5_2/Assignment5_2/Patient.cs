using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_2
{
    class Patient
    {
        public string Name { get; set; }
        public string Reason { get; set; }
        public string Doctor { get; set; }

        public Patient(string name, string reason, string doctor)
        {
            this.Name = name;
            this.Reason = reason;
            this.Doctor = doctor;
        }
    }
}
