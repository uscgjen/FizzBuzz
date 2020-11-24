using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzzHelper helper = new FizzBuzzHelper();
            string result = String.Empty;
            for (int i = 0; i < 100; i++)
            {
                result = helper.ReturnString(i);
                if (!string.IsNullOrEmpty(result))
                {
                    Console.WriteLine($"{result}");
                }
            }

            Console.ReadKey();
        }
    }
}
