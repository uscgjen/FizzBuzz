using System;
namespace FizzBuzz
{
    public class FizzBuzzHelper
    {
        public FizzBuzzHelper()
        {
        }

        public string ReturnString(int value)
        {
            if (value % 3 == 0 && value % 5 == 0)
                return "FizzBuzz";
            else if (value % 3 == 0)
                return "Fizz";
            else if (value % 5 == 0)
                return "Buzz";
            else
                return string.Empty;
        }
    }
}
