using System;

class Program
{
    static void Main(string[] args)
    {
            string response = " ";
            do
            {   
                Reference reference = new Reference("D&C", 18 , 10, 11);
                Console.WriteLine(reference.GetDisplayText());
                Word verse = new Word("Remember the worth of souls is great in the sight of God. For, behold, the Lord your Redeemer suffered death in the flesh; wherefore he suffered the pain of all men, that all men might repent and come unto him.");
                Console.WriteLine(verse.GetDisplayText());
                Console.WriteLine("Please enter to continue or type 'quit' to finish");
                response = Console.ReadLine();
                Console.Clear();
            } while (response != "quit");
    }
}