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
            if (luku%3==0)
            {
                return "Fizz";
            }

            if (luku % 5 == 0)
            {
                return "Buzz";
            }

            else
            {
                return luku.ToString();
            }
        }
    }
}