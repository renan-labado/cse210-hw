using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        List<int> numbers = new List<int>();
        int sumOfNumbers = 0;
        float average = 0;
        int largestNumber = 0;
        int number = -1;
        int smallestPositive = 123456;
        while (number != 0)
        {
            Console.Write("Enter Number: ");
            string numberText = Console.ReadLine();
            number = int.Parse(numberText);
            if (number != 0)
            {
                numbers.Add(number);
            }
        }
        int i = 0;
        for (i = 0; i < numbers.Count; i++)
        {
            int numberFromList = numbers[i];
            sumOfNumbers += numberFromList;
            if (numberFromList > largestNumber)
            {
                largestNumber = numberFromList;
            }
            if (numberFromList > 0 && numberFromList < smallestPositive)
            {
                smallestPositive = numberFromList;
            }
        }
        Console.WriteLine($"The sum is: {sumOfNumbers}");
        average = ((float)sumOfNumbers) / numbers.Count;
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNumber}");
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");

    }   
}