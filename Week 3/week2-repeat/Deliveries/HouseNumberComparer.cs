using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deliveries
{
    class HouseNumberComparer : IComparer<Deliverable>
    {
        public int Compare(Deliverable x, Deliverable y)
        {
            if(x.Buyer.Housenumber < y.Buyer.Housenumber)
            {
                return -1;
            }
            else if (x.Buyer.Housenumber == y.Buyer.Housenumber)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
}
