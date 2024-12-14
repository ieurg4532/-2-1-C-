using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_1__C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter:\n1, First, first, FIRST\n2, Second, second, SECOND\n3, Third, third, THIRD\n");
            Console.Write("Enter variant: ");
            string variant = Console.ReadLine();

            double z; 
            switch (variant)
            {
                case "1":
                case "First":
                case "first":
                case "FIRST": 
                    z = Math.Pow(Math.Sin(x), 2);
                    Console.WriteLine($"Result: {z}");
                    break;
                case "2":
                case "Second":
                case "second":
                case "SECOND":
                    if (x > 0) 
                    { 
                    z = Math.Pow(Math.Log10(x), 2);
                    Console.WriteLine($"Result: {z}");
                    }
                    else Console.WriteLine("Unable to calculate");
                    break;
                case "3":
                case "Third":
                case "third":
                case "THIRD":
                    z = 1 / Math.Cos(Math.Pow(x, 3));
                    Console.WriteLine($"Result: {z}");
                    break;
            }
        }
    }
}
