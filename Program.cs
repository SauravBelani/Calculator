using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The sum of the {x} and {y} is {x+y}");
            Console.WriteLine($"The subtraction of the {x} and {y} is {x-y}");
            Console.WriteLine($"The multiplication  of the {x} and {y} is {x*y}");
            Console.WriteLine($"The division  of the {x} and {y} is {x/y}");
        }
    }
}
