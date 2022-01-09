using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    class Program
    {
        static void Main(string[] args)
        {
            // prostokąt(kwadrat)
            // prostokąt w środku pusty
            // trójkąt 
            /*
             * X
             * XX
             * XXX 
             * 
             * XXX
             *  XX
             *   X
             *   
             *   X
             *  XXX
             * XXXXX 
             */

            Console.WriteLine("Podaj n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            // kwadrat pełny w środku:

            for (int i = 0; i < n; i++) // i - numer wiersza // n przebiegów, n wierszy
            {
                // pętla wypisuje n znaków 'X'
                // przejście do nowej linii
            }

            // kwadrat pusty w środku:
            for (int i = 0; i < n; i++) // i - numer wiersza // n przebiegów, n wierszy
            {
                // pętla wypisuje n znaków 'X' + warunek kiedy ma być 'X' a kiedy ma być spacja
                // przejście do nowej linii
            }

            /*
            * X
            * XX
            * XXX 
            */

            for (int i = 0; i < n; i++) // i - numer wiersza // n przebiegów, n wierszy
            {
                // pętla wypisuje tyle znaków 'X' ile wynosi numer wiersza(liczony od 1)
                // przejście do nowej linii
            }

            /*
           * X
           * XX
           * X X 
           * XXXX
           */
            for (int i = 0; i < n; i++) // i - numer wiersza // n przebiegów, n wierszy
            {
                // pętla wypisuje tyle znaków 'X' ile wynosi numer wiersza(liczony od 1) + warunek 
                // kiedy ma być 'X' a kiedy ma być spacja 
                // przejście do nowej linii
            }

            /*
             *     X
             *    XX 
             *   XXX 
             */

            /*
             * WZÓR s + i = n, s = n - i
             */

            for (int i = 1; i <= n; i++) // i - numer wiersza // n przebiegów, n wierszy
            {
                // pętla wypisuje spacje
                // pętla wypisuje 'X'
                // przejście do nowej linii
            }

        }
    }
}
