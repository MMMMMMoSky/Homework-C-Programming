using System;

namespace ArrayQuery
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generating a random integer array..."); 
            
            Program obj = new Program();

            int[] arr = obj.randIntArray();
            obj.printIntArray(arr);

            int min = int.MaxValue;
            int max = int.MinValue;
            int sum = 0;
            double aver = 0;

            foreach (int i in arr)
            {
                min = Math.Min(min, i);
                max = Math.Max(max, i);
                sum += i;
            }
            aver = (double)sum / arr.Length;

            Console.WriteLine("max: {0}  min: {1}  sum: {2}  aver: {3:#0.00}",
                    max, min, sum, aver);

        }
        
        private int[] randIntArray()
        {
            Random rnd = new Random();
            int len = rnd.Next(5, 10);
            int[] res = new int[len];
            for (int i = 0; i < len; i++)
            {
                res[i] = rnd.Next(-1000, 1000);
            }
            return res;
        }

        private void printIntArray(int[] arr)
        {
            bool dot = false;
            Console.Write("[");
            foreach (int i in arr)
            {
                if (dot)
                {
                    Console.Write(", ");
                }
                Console.Write(Convert.ToString(i));
                dot = true;
            }
            Console.Write("]\n");
        }
    }
}
