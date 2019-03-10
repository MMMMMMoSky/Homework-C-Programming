using System;

namespace PrimeFactors_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input an integer: ");

            long x;

            // Make sure it's valid
            try
            {
                x = Convert.ToInt64(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: please input an integer");
                return;
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: please input an integer in range of [{0}, {1}]",
                        long.MinValue, long.MaxValue);
                return;
            }

            // Algorithm begins
            Console.Write("Prime factors: ");
            for (long i = 2; Math.Abs(x) > 1; i++)
            {
                if (x % i == 0)
                {
                    Console.Write(Convert.ToString(i) + " ");
                }
                while (x % i == 0)
                {
                    x /= i;
                }
            }
        }
    }
}
