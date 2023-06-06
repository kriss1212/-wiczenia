

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wpisz pierwszą liczbę licznika");
            int a = (int)inputValue();
            Console.WriteLine("Wpisz drugą liczbę licznika");
            int b = (int)inputValue();
            Console.WriteLine("Wpisz Pierwszą liczbę mianownika");
            int c = (int)inputValue();
            Console.WriteLine("wpisz drugą liczbę mianownika");
            int d = (int)inputValue();

            if (b == 0 || d == 0)
            {
                Console.WriteLine("Brak rozwiązania");
                Console.ReadKey();
            }
            else if (b == d)
            {
                int x = a + c;
                Console.WriteLine("Twój licznik to: " + x);
                Console.WriteLine("Twój mianownik to: " + d);
                Console.ReadKey();
            }
            else if (b != d)
            {
                int y = b * d;
                a = a * d;
                c = c * b;
                int x = a + c;
                Console.WriteLine("Twój licznik to: " + x);
                Console.WriteLine("Twój mianownik to: " + y);
                Console.ReadKey();
            }


        }
        private static double inputValue()
        {
            double result;
            while (!double.TryParse(Console.ReadLine(), out result)) ;
            return result;
        }
    }
}