using System;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first resistor:");
            double R1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter second resistor:");
            double R2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter third resistor:");
            double R3 = Convert.ToDouble(Console.ReadLine());

            double Result = R1 + R2 + R3;

            Console.WriteLine("Result resistance is " + Result);

        }
    }
}//Обчислення опору ел ланцюга, що складається з 3х послідовно з*єднаних резисторів//