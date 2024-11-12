using System;
namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a six-digit number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int reversedNumber = 0;
            int temp = number;

            for (int i = 0; i < 6; i++)
            {
                reversedNumber = reversedNumber * 10 + temp % 10;
                temp /= 10;
            }

            Console.WriteLine($"Reversed number: {reversedNumber}");
        }
    }
}