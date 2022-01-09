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
                for (int j = 0; j < n; j++) // j - numer kolumny
                {
                    Console.Write("X");
                }
                // przejście do nowej linii
                Console.WriteLine();
            }

            Console.WriteLine();
            // kwadrat pusty w środku:
            for (int i = 0; i < n; i++) // i - numer wiersza // n przebiegów, n wierszy
            {
                // pętla wypisuje n znaków 'X' + warunek kiedy ma być 'X' a kiedy ma być spacja
                // przejście do nowej linii
                for (int j = 0; j < n; j++) // j - numer kolumny
                {
                    if (j == 0 || j == n - 1 || i == 0 || i == n - 1)
                    {
                        Console.Write("X");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                // przejście do nowej linii
                Console.WriteLine();
            }
            Console.WriteLine();
            /*
            * X
            * XX
            * XXX 
            */

            for (int i = 0; i < n; i++) // i - numer wiersza // n przebiegów, n wierszy
            {
                // pętla wypisuje tyle znaków 'X' ile wynosi numer wiersza(liczony od 1)
                // przejście do nowej linii
                for (int j = 0; j < i+1; j++) // j - numer kolumny
                {
                    Console.Write("X");
                }
                // przejście do nowej linii
                Console.WriteLine();
            }


            Console.WriteLine();
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
                for (int j = 0; j < i+1; j++) // j - numer kolumny
                {
                    if (j == 0 || j == i  || i == 0 || i == 1 || i==n-1)
                    {
                        Console.Write("X");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                // przejście do nowej linii
                Console.WriteLine();
            }

            /*
             *     X
             *    XX 
             *   XXX 
             */

            /*
             * WZÓR s + i = n, s = n - i
             */
            Console.WriteLine();
            for (int i = 1; i <= n; i++) // i - numer wiersza // n przebiegów, n wierszy
            {
                // pętla wypisuje spacje
                for (int j = 0; j < n-i; j++)
                {
                    Console.Write(" ");
                }
                // pętla wypisuje 'X'
                for (int j = 0; j < i; j++)
                {
                    Console.Write("X");
                }
                // przejście do nowej linii
                Console.WriteLine();
            }

            /*
            * WZÓR s + x = n, x = n - s
            */
            Console.WriteLine();
            for (int s = 4; s >= 0; s--) // s - numer wiersza
            {
                // pętla wypisuje spacje
                for (int j = 0; j < s; j++)
                {
                    Console.Write(" ");
                }
                // pętla wypisuje 'X'
                for (int j = 0; j < n-s; j++)
                {
                    Console.Write("X");
                }
                // przejście do nowej linii
                Console.WriteLine();
            }

            Console.ReadKey();

        }
    }
}
