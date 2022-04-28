using System;
using System.Collections.Generic;

namespace IceCreamShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Case menu = new Case();
            List<Flavor> availableFlavors = menu.Flavors;
            List<Cone> availableCones = menu.Cones;

            // TODO: Use a Comparer class to sort the 'flavors' array alphabetically by the 'name'
            //  field.



            // TODO: Use a Comparator class to sort the 'cones' array in increasing order by the 'cost'
            //  field.

            Console.WriteLine("\n*****Cone cost before********");

            ConeComparer compareCones = new ConeComparer();

            foreach (Cone c in availableCones)
            {
                Console.WriteLine($"{c.Name} ${c.Cost}");
            }

            //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            Console.WriteLine("\n*****Cone cost After********");

            availableCones.Sort(compareCones);
            foreach (Cone c in availableCones)
            {
                Console.WriteLine($"{c.Name} ${c.Cost}");
            }

            // TODO: Print the 'flavors' and 'cones' lists (in a clear manner) to verify the sorting.
            //Alleregens

            Console.WriteLine("\n*****Before according to Allergens count Flavours********");

            FlavorComparer comparer1 = new FlavorComparer();

            foreach (Flavor flavor in availableFlavors)
            {
                Console.WriteLine($"{flavor.Name} Allergen Count : {flavor.Allergens.Count}");
            }

            //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            Console.WriteLine("\n*****After according to Allergens count Flavours********");
            availableFlavors.Sort(comparer1);

            foreach (Flavor flavor in availableFlavors)
            {
                Console.WriteLine($"{flavor.Name} Allergen Count : {flavor.Allergens.Count}");
            }
        }
    }
}
