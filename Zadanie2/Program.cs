using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] tab = new int[n];

            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine("Podaj tab[{0}]", i);
                tab[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine();
            foreach (int item in tab)
            {
                Console.Write("{0} ", item);
            }

            int licznik = 0; // zlicza liczby ujemne w tablicy
            foreach (int item in tab)
            {
                if (item < 0)
                {
                    licznik++;
                }
            }

            Console.WriteLine("ilość liczb ujemnych w tablicy: {0}", licznik);

            // obliczyć ile liczb w tablicu jest z przedziału <-2;2)
            licznik = 0;
            foreach (int item in tab)
            {
                if (item>=-2 && item < 2)
                {
                    licznik++;
                }
            }

            Console.WriteLine("ilość liczb z <-2;2) w tablicy: {0}", licznik);

            Console.ReadKey();
        }
    }
}
