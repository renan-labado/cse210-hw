using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        //Console.Write("What is the magic number? ");
        //string magicNumberText = Console.ReadLine();
        //int magicNumber = int.Parse(magicNumberText);
        int guessNumber = 0;
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        int numberOfGuesses = 0;
        Console.WriteLine(magicNumber);
        while (guessNumber != magicNumber)
        {
            Console.Write("What is your guess? ");
            string guessNumberText = Console.ReadLine();
            guessNumber = int.Parse(guessNumberText);
            numberOfGuesses += 1;
            if (guessNumber > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guessNumber < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("Got it!");
            }
        }
        Console.WriteLine($"You guessed {numberOfGuesses} times!");
    }   
}