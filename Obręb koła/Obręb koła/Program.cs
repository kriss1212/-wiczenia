
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadź x");
            double x = inputValue();
            x = Math.Sqrt(x);
            Console.WriteLine("Wprowadź y");
            double y = inputValue();
            y = Math.Sqrt(y);
            Console.WriteLine("Wprowadź r");
            double r = inputValue();
            r = Math.Sqrt(r);
            if (x + y <= r)
            {
                Console.WriteLine("Punkt leży w obrębie koła o środku O(0,0)");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Punkt nie leży w obrębie koła o środku O(0,0)");
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