using System;

namespace Kalkylator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number: ");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int numberTwo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Press 1 for addition:");
            Console.WriteLine("Press 2 for subtraction");
            Console.WriteLine("Press 3 for multification");
            Console.WriteLine("Press 4 for divition");
            int numberThree = Convert.ToInt32(Console.ReadLine());
        }
    }
}
