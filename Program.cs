using System;
namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            int A = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int B = int.Parse(Console.ReadLine());
            if (A < B)
            {
                for (int i = A; i <= B; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write(i + " ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("The first number must be less than the second number");
            }
        }
    }
}