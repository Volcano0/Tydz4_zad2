using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tydz4_zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Podaj liczbę");
                var number = int.Parse(Console.ReadLine());
                var FizzBuzz = new FizzBuzz();

                var result = FizzBuzz.FizzBuzzCheck(number);

                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Nie podano liczby");
            }


            Console.ReadKey();
        }
    }
}