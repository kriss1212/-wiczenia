﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadź pierwszą liczbę");
            double x = inputValue();
            Console.WriteLine("Wybierz typ działania: 1- dodawanie, 2- odejmowanie, 3- mnożenie, 4- dzielenie");
            double d = inputValue();
            double wynik;
            Console.WriteLine("Wprowadź drugą liczbę");
            double y = inputValue();
           
            if (d == 1)
            {
                wynik = x + y;
                Console.WriteLine("Wynik dodawania wynosi: " + wynik);
                Console.ReadKey();
            }
            else if (d == 2)
            {
                wynik = x - y;
                Console.WriteLine("Wynik odejmowania wynosi: " + wynik);
                Console.ReadKey();
            }
            else if (d == 3)
            {
                wynik = x * y;
                Console.WriteLine("Wynik mnożenia wynosi: " + wynik);
                Console.ReadKey();
            }
            else if (d == 4)
            {
                if (y == 0)
                {
                    Console.WriteLine("Wynik dzielenia wynosi: " + x + " / " + y);
                    Console.ReadKey();
                }
                else
                {
                    wynik = x / y;
                    Console.WriteLine("Wynik dzielenia wynosi: " + wynik);
                    Console.ReadKey();
                }
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