namespace Task_2

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 5 numbers: ");
            int[] numbers = new int[5];
            for (int i = 0; i < 5; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            int sum = 0;
            int max = numbers[0];
            int min = numbers[0];
            int mult = 1;
            for (int i = 0; i < 5; i++)
            {
                sum += numbers[i];
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
                mult *= numbers[i];
            }
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Max: " + max);
            Console.WriteLine("Min: " + min);
            Console.WriteLine("Mult: " + mult);
        }
    }
}