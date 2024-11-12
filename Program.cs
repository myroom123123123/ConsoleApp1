using System;
namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of the line: ");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the symbol of the line: ");
            char symbol = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter the direction of the line (horizontal or vertical): ");
            string direction = Console.ReadLine();
            if (direction == "horizontal")
            {
                for (int i = 0; i < length; i++)
                {
                    Console.Write(symbol);
                }
            }
            else if (direction == "vertical")
            {
                for (int i = 0; i < length; i++)
                {
                    Console.WriteLine(symbol);
                }
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}