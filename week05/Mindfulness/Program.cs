using System;

class Program
{
    static void Main(string[] args)
    {
        int response = 0;
        while (response != 4)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("     1. Start breathing activity");
            Console.WriteLine("     2. Start reflecting activity");
            Console.WriteLine("     3. Start listing activity");
            Console.WriteLine("     4. Quit");
            Console.Write("Select a choice from the menu: ");
            response = int.Parse(Console.ReadLine());
            if (response == 1)
            {
                Console.Clear();
                string name = "Breathing";
                string description = "This activity will help you relax by helping you breathing in and out slowly. This will help you process emotions, and clear your mind by focusing on breathing.";
                BreathingActivity breathing = new BreathingActivity(name, description);
                breathing.DisplayStartingMessage();
                breathing.AskForDuration();
                Console.Clear();
                Console.WriteLine("Get ready....");
                breathing.ShowSpinner();
                breathing.Run();
                breathing.DisplayEndingMessage();

            }
            else if (response == 2)
            {
                Console.Clear();
                string name = "Reflecting";
                string description = "This activity will help you reflect and ponder about the times in your life or your day when you have shown strength and resilience. This will help empower you and use that power to help with the other aspects of your life.";
                ReflectingActivity reflecting = new ReflectingActivity(name, description);
                reflecting.DisplayStartingMessage();
                reflecting.AskForDuration();
                Console.Clear();
                Console.WriteLine("Get ready....");
                reflecting.ShowSpinner();
                reflecting.Run();
                reflecting.DisplayEndingMessage();
            }
            else if (response == 3)
            {
                Console.Clear();
                string name = "Listing";
                string description = "This activity will help you reflect on the good things of your life by having you list as many things as you can for a specific prompt.";
                ListingActivity listing = new ListingActivity(name, description);
                listing.DisplayStartingMessage();
                listing.AskForDuration();
                Console.Clear();
                Console.WriteLine("Get ready....");
                listing.ShowSpinner();
                listing.Run();
                listing.DisplayEndingMessage();
            }
            else
            {
                break;
            }
        }
    }
}