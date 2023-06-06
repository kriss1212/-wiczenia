using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double w;
            double h;
            Console.WriteLine("Podaj wagę w kilogramach");
            w = inputValue();
            Console.WriteLine("Podaj wzrost w metrach(maksymalnie 3m)");
            h = inputValue();
            while (h > 3)
            {
                Console.WriteLine("Podaj wzrost w metrach(maksymalnie 3m)");
                h = inputValue();
            }
            double bmi;
            bmi = w / (h * h);
            Console.WriteLine("Twoje bmi wynosi " + bmi);
            Console.WriteLine();
            Console.WriteLine("BMI większe niż 30 oznacza otyłość");
            Console.WriteLine("BMI większe bądź równe 25, ale mniejsze lub równe 29,9 oznacza nadwagę");
            Console.WriteLine("BMI większe bądź równe 18,5, ale mniejsze lub równe 24,9 oznacza prawidłową masę ciała");
            Console.WriteLine("BMI mniejsze niż 18,5 oznacza niedowagę");
            Console.ReadKey();
        }
        private static double inputValue()
        {
            double result;
            while (!double.TryParse(Console.ReadLine(), out result)) ;
            return result;
        }
    }

}