using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz
{
    public class FizzBuzzExecuter
    {
        public string Execute(int number)
        {
            // se o numero for divisivel por 3 (ou seja, a sobra ser 0!), coloca fizz
            // number % 3 == 0

            if (number % 3 == 0 && number % 5 == 0)
            {
                return "fizzbuzz";
            }

            if (number % 3 == 0)
            {
                return "fizz";
            }

            if (number % 5 == 0)
            {
                return "buzz";
            }

            return number.ToString();
            
                
        }
    }
}
