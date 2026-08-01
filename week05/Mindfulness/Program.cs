// i tried making something for creativity, since one of the common things that the activity do is get a duration, i added 
// AskForDuration() function in Activity.cs

using System;
using System.Runtime.CompilerServices;

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
                int duration = breathing.AskForDuration();
                BreathingActivity breathing1 = new BreathingActivity(name, description, duration);
                Console.Clear();
                Console.WriteLine("Get ready....");
                breathing1.ShowSpinner(5);
                breathing1.ShowCountDown(5);
                breathing1.Run();
                breathing1.DisplayEndingMessage();

            }
            else if (response == 2)
            {
                Console.Clear();
                string name = "Reflecting";
                string description = "This activity will help you reflect and ponder about the times in your life or your day when you have shown strength and resilience. This will help empower you and use that power to help with the other aspects of your life.";
                ReflectingActivity reflecting = new ReflectingActivity(name, description);
                reflecting.DisplayStartingMessage();
                int duration = reflecting.AskForDuration();
                ReflectingActivity reflecting1 = new ReflectingActivity(name, description, duration);
                Console.Clear();
                reflecting1.SetTheLists();
                Console.WriteLine("Get ready....");
                reflecting1.ShowSpinner(5);
                reflecting1.ShowCountDown(5);
                reflecting1.Run();
                reflecting1.DisplayEndingMessage();
            }
            else if (response == 3)
            {
                Console.Clear();
                string name = "Listing";
                string description = "This activity will help you reflect on the good things of your life by having you list as many things as you can for a specific prompt.";
                ListingActivity listing = new ListingActivity(name, description);
                listing.DisplayStartingMessage();
                int duration = listing.AskForDuration();
                ListingActivity listing1 = new ListingActivity(name, description, duration);
                Console.Clear();
                listing1.SetTheList();
                Console.WriteLine("Get ready....");
                listing1.ShowSpinner(5);
                listing1.Run();
                listing1.DisplayEndingMessage();
            }
            else
            {
                break;
            }
        }
    }
}