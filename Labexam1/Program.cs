
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int sumOfDigits = CalculateSumOfDigits(number);

        if (number % sumOfDigits == 0)
        {
            Console.WriteLine("The number is divisible by the sum of its digits.");
        }
        else
        {
            Console.WriteLine("The number is not divisible by the sum of its digits.");
        }

        DrawRectangle(number);
    }

    static int CalculateSumOfDigits(int number)
    {
        int sum = 0;
        while (number != 0)
        {
            sum += number % 10;
            number /= 10;
        }
        return sum;
    }

    static void DrawRectangle(int digit)
    {
        for (int row = 1; row <= 5; row++)
        {
            for (int col = 1; col <= 3; col++)
            {
                if (row == 1 || row == 5 || col == 1 || col == 3)
                {
                    Console.Write(digit);
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}