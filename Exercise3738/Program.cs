using System;

namespace Exercise3738
{
    class Program
    {
        static void Main(string[] args)
        {

            //37
            int sum = 0;
            int sums = 0;
            int average = 0;
            string answer = "";

            int[] fiveNumbers = new int[5];
            do
            {
                for (int i = 0; i < fiveNumbers.Length; i++)
                {
                    Console.Write("Please enter a number: ");
                    fiveNumbers[i] = int.Parse(Console.ReadLine());

                }
                for (int i = 0; i < fiveNumbers.Length; i++)
                {
                    sum += fiveNumbers[i];

                }
                Console.WriteLine("Your sum is:  " + sum);

                Console.WriteLine("Would you like to continue? y/n");
                answer = Console.ReadLine();

            } while (answer.ToLower() != "n");
            Console.WriteLine("Goodbye");




            //38
            int[] numbers = new int[5];
            do
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.Write("Please enter a number: ");
                    numbers[i] = int.Parse(Console.ReadLine());

                }
                for (int i = 0; i < numbers.Length; i++)
                {
                    sums += numbers[i];
                    average = sums / 5;

                }
                Console.WriteLine("Your average is:  " + average);

                Console.WriteLine("Would you like to continue? y/n");
                answer = Console.ReadLine();

            } while (answer.ToLower() != "n");
            Console.WriteLine("Goodbye");

        }
    }
}




