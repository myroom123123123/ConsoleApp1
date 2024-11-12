using System;
namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the range of numbers:");
            int n = Convert.ToInt32(Console.ReadLine());
            int a = 0;
            int b = 1;
            int c = 0;
            Console.Write(a + " ");
            Console.Write(b + " ");
            for (int i = 0; i < n; i++)
            {
                c = a + b;
                if (c <= n)
                {
                    Console.Write(c + " ");
                    a = b;
                    b = c;
                }
            }
        }
    }
}