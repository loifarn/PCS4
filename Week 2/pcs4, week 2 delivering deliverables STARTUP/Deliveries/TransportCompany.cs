using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Deliveries
{
    class TransportCompany
    {
        private List<Person> myPersons;
        private List<Deliverable> myDeliverables;

        public TransportCompany()
        {
            this.myPersons = new List<Person>();
            this.myDeliverables = new List<Deliverable>();
        }

        public List<Person> Persons { get { return this.myPersons; } }
        public List<Deliverable> Deliverables { get { return this.myDeliverables; } }


        public Person FindPerson(int id)
        {
            foreach (Person p in this.myPersons)
            {
                if (p.ID == id)
                {
                    return p;
                }
            }
            return null;
        }

        public void AddPerson(Person p)
        {
            if (this.FindPerson(p.ID) == null)
            {
                this.myPersons.Add(p);
            }
            else
            {
                throw new Exception("Be aware: nothing is added!!!");
            }
        }

        public Deliverable FindDeliverable(int id)
        {
            foreach (Deliverable d in this.myDeliverables)
            {
                if (d.ID == id)
                {
                    return d;
                }
            }
            return null;
        }

        public void AddDeliverable(Deliverable d)
        {
            if (FindDeliverable(d.ID) == null)
            {
                myDeliverables.Add(d);
            }
            else
            {
                throw new Exception("Be aware: nothing is added!!!");
            }
        }

        public void LoadPersonsFromFile(String filename)
        {
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(new FileStream(filename, FileMode.Open, FileAccess.Read));
                this.myPersons.Clear();
                String name, street, postalcode, city;
                int id, housenr;
                name = sr.ReadLine();
                while (name != null)
                {
                    street = sr.ReadLine();
                    housenr = Convert.ToInt32(sr.ReadLine());
                    postalcode = sr.ReadLine();
                    city = sr.ReadLine();
                    id = Convert.ToInt32(sr.ReadLine());
                    this.myPersons.Add(new Person(id, name, street, housenr, postalcode, city));
                    name = sr.ReadLine();
                    name = sr.ReadLine(); //and again read a line, because of the delimiter between persons(line with the stars)
                }
            }
            catch (IOException) { }
            finally
            {
                if (sr != null) sr.Close();
            }
        }

        public void LoadDeliverablesFromFile(String filename)
        {
            using (StreamReader sr = new StreamReader(new FileStream(filename, FileMode.Open, FileAccess.Read)))
            {
                string[] tmp;
                string line;

                while((line = sr.ReadLine()) != null)
                {
                    tmp = line.Split(' ');

                    int id = Convert.ToInt32(tmp[0]);
                    int weight = Convert.ToInt32(tmp[1]);
                    Person person = FindPerson(Convert.ToInt32(tmp[2]));

                    AddDeliverable(new Deliverable(id, weight, person));
                }
            }
        }



        /// <summary>
        /// SortByWeight sorts the elements of the deliverables-list from a low weight to a high weight.
        /// </summary>
        public void SortByWeight()
        {
            myDeliverables = myDeliverables.OrderBy(Deliverable => Deliverable.Weight).ToList();
        }

        /// <summary>
        /// SortByName sorts the elements of the deliverables-list alfabetically by buyer's name.
        /// </summary>
        public void SortByName()
        {
            myDeliverables = myDeliverables.OrderBy(Deliverable => Deliverable.Buyer.Name).ToList();
        }

        /// <summary>
        /// SortById sorts the elements of the deliverables-list from a low id to a high id.
        /// </summary>
        public void SortById()
        {
            myDeliverables = myDeliverables.OrderBy(Deliverable => Deliverable.ID).ToList();
        }

        /// <summary>
        /// SortByAddress sorts the elements of the deliverables-list "alfabetically by street; then by increasing house-number".
        /// So elements with a different street are sorted alfabetically by street.
        /// Elements with the same street are sorted by increasing house-number. 
        /// </summary>
        public void SortByAddress()
        {
            myDeliverables = myDeliverables.OrderBy(Deliverable => Deliverable.Buyer.Housenumber).ToList();

        }

        /// <summary>
        /// SortForPostman sorts the elements of the deliverables-list alfabetically by street,
        /// then by postman-ordered house-numbers.
        /// The postman walks along the street, first the side of the street with the odd numbers (in an increasing order),
        /// then back on the other side of the street for the even house-numbers (in a decreasing order). 
        /// </summary>
        public void SortForPostman()
        {
            //First sort by street
            myDeliverables = myDeliverables.OrderBy(Deliverable => Deliverable.Buyer.Street).ToList();

            //Creating lists for odds, even and combined
            List<Deliverable> odds = new List<Deliverable>();
            List<Deliverable> even = new List<Deliverable>();
            List<Deliverable> combined = new List<Deliverable>();

            //Iterate through myDeliverables. Split list into odds and evens.
            foreach(Deliverable d in myDeliverables)
            {
                if (d.ID % 2 == 0)
                {
                    even.Add(d);
                }
                else
                {
                    odds.Add(d);
                }

                //Sort odds and even lists
                odds = odds.OrderBy(Deliverable => Deliverable.Buyer.Housenumber).ToList();
                even = even.OrderBy(Deliverable => Deliverable.Buyer.Housenumber).ToList();
            }

            //Add sorted odds first, then sorted evens.
            foreach (Deliverable d in odds)
            {
                combined.Add(d);
            }
            foreach (Deliverable d in even)
            {
                combined.Add(d);
            }

            //TODO does not work as intended.. need to merge better
        }

    }
}
