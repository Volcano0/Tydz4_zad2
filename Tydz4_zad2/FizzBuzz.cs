using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tydz4_zad2
{
    class FizzBuzz
    {
        public string FizzBuzzCheck(int number)
        {

            if (number % 3 == 0 && number % 5 == 0)
                return "FizzBuzz";
            else if (number % 3 == 0)
                return "Fizz";
            else if (number % 5 == 0)
                return "Buzz";
            else
                return $"Podana liczba to: {number}";
            
        }
    }
}
