using System;

namespace Yksikkötestaus
{
    public class FizzBuzz
    {
        public FizzBuzz()
        {

        }

        public string Luku(int luku)
        {
            if (luku == 3)
            {
                return "Fizz";
            }

            if (luku == 5)
            {
                return "Buzz";
            }

            else
            {
                return "wuh";
            }
        }
    }
}