using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj ile: ");
            int ile = Convert.ToInt32(Console.ReadLine());

            int ilosc = 0; // ilość już wypisanych liczb

            int liczba = 13;

            while (ilosc < ile)
            {

                if (liczba % 2 == 1) {

                    ilosc++;
                    Console.Write("{0} ", liczba);
                }

                liczba += 13;
            }

            Console.ReadKey();
        }
    }
}
