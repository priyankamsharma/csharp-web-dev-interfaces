using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace IceCreamShop
{
    public class ConeComparer : IComparer<Cone>
    {
        public int Compare(Cone x, Cone y)
        {
            //if cone cost x>y then return 1
            //if cone cost y>x then return -1
            //if both same x=y return 0

            double difference = x.Cost - y.Cost;
            if (difference > 0)
            {
                return 1;
            }
            else if (difference < 0)
            {
                return -1;
            } 
            else
            {
                return 0;
            }
        }
    }
}
