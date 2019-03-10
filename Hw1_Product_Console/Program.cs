using System;

namespace Product_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            int lhs, rhs;
            Console.WriteLine("------A x B Problem------");

            Console.Write("Input an integer: ");
            lhs = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input another integer: ");
            rhs = Convert.ToInt32(Console.ReadLine());

            Console.Write("There product: ");
            Console.WriteLine(Convert.ToString(lhs * rhs));
        }
    }
}
