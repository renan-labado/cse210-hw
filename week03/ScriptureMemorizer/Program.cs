using System;

class Program
{
    static void Main(string[] args)
    {   
        Console.Clear();
        Reference reference = new Reference("D&C", 18 , 10, 11);
        Scripture scripture = new Scripture(reference, "Remember the worth of souls is great in the sight of God. For, behold, the Lord your Redeemer suffered death in the flesh; wherefore he suffered the pain of all men, that all men might repent and come unto him.");
        Console.WriteLine(reference.GetDisplayText());
        Console.WriteLine("");
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("Please enter to continue or type 'quit' to finish");
        string response = Console.ReadLine();
        bool completelyHidden = false;
        while (response != "quit")
        {
            Console.Clear();
            Console.WriteLine(reference.GetDisplayText());
            Console.WriteLine("");
            Console.WriteLine(scripture.GetDisplayText());
            Random random = new Random();
            int numberOne = random.Next(0, 41);
            int numberTwo = random.Next(0, 41);
            int numberThree = random.Next(0, 41);
            scripture.HideRandomWords(numberOne);
            scripture.HideRandomWords(numberTwo);
            scripture.HideRandomWords(numberThree);

            Console.WriteLine("Please enter to continue or type 'quit' to finish");
            response = Console.ReadLine();
            completelyHidden = scripture.IsCompletelyHidden();
            if (completelyHidden == true)
            {
                break;
            }
        }
    }
}