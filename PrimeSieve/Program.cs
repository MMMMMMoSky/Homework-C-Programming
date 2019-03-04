using System;
using System.IO;
using System.Diagnostics;

namespace PrimeSieve
{
    class Program
    {
        static void Main(string[] args)
        {

            Stopwatch sw = new Stopwatch();
            sw.Start();

            int max = 1000000;
            // TODO: let int[] to be return value, @para out bool[] to be optional
            sievePrime(max, out bool[] prime, out int[] arr);   

            sw.Stop();

            // print some info
            Console.Write("Generated a prime number table in range of [0, {0}] ", max);
            Console.Write("in {0} ms\n", sw.Elapsed.TotalMilliseconds);
            Console.WriteLine("{0} prime numbers total.", arr.Length);

            // write into file
            StreamWriter f = new StreamWriter("result.txt");
            foreach (int i in arr)
            {
                f.WriteLine(Convert.ToString(i));
            }
            f.Close();

            Console.WriteLine("Written into file 'result.txt'");
        }

        // my blog 
        // https://blog.csdn.net/qq_25978793/article/details/48180117
        public static void sievePrime(int max, out bool[] p, out int[] arr)
        {
            p = new bool[max + 1];
            int num = max - 1;
            p[0] = p[1] = true;

            // First, get rid of all evens
            for (int i = 2; i * 2 <= max; i++)
            {
                if (p[i * 2] == false)
                {
                    num--;
                }
                p[i * 2] = true;
            }

            // Then, get rid of multiples of all known primes
            for (int i = 3; i * i <= max; i += 2)
            {
                if (p[i])
                {
                    continue;
                }
                for (int j = i * i; j <= max; j += i * 2)
                {
                    if (p[j] == false)
                    {
                        num--;
                    }
                    p[j] = true;
                }
            }
            
            arr = new int[num];
            for (int i = 2, j = 0; i <= max; i++)
            {
                if (p[i] == false)
                {
                    arr[j++] = i; 
                }
            }
        }
    }
}
