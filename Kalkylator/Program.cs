using System;

namespace Kalkylator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number: ");
            double numberOne = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            double numberTwo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Press 1 for addition:");
            Console.WriteLine("Press 2 for subtraction");
            Console.WriteLine("Press 3 for multiplication");
            Console.WriteLine("Press 4 for division");
            double numberThree = Convert.ToDouble(Console.ReadLine());
            switch (numberThree)
            {
                case 1:
                    Console.WriteLine(numberOne + numberTwo);
                    break;
                case 2:
                    Console.WriteLine(numberOne - numberTwo);
                    break;
                case 3:
                    Console.WriteLine(numberOne * numberTwo);
                    break;
                case 4:
                    if (numberTwo != 0)
                        Console.WriteLine(numberOne / numberTwo);
                    else
                        Console.WriteLine("Cant divide by zero");
                    break;
                    


            }
        }
    }
}
