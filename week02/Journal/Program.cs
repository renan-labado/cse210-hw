using System;
using System.IO; 


// for creativity, i added a method that would remove an entry to correct something such as 
// mispelled words, wrong entries, etc.
class Program
{
    static void Main(string[] args)
    {
        Journal newJournal = new Journal();
        PromptGenerator prompt = new PromptGenerator();
        prompt._prompts.Add("Who was the most interesting person I interacted with today?");
        prompt._prompts.Add("What was the best part of my day?");
        prompt._prompts.Add("How did I see the hand of the Lord in my life today?");
        prompt._prompts.Add("What was the strongest emotion I felt today?");
        prompt._prompts.Add("If I had one thing I could do over today, what would it be?");
        prompt._prompts.Add("One a scale of 1-10, How would I rate my day? Why?");
        prompt._prompts.Add("Tell an experience where you have felt the Holy Ghost today.");
        prompt._prompts.Add("Is there someone that you helped today feel happy? What did you do?");
        prompt._prompts.Add("Is there something bad that happened today? What is it?");
        


        Console.WriteLine("Hello! Welcome to your Digital Journal.");
        int action = 0;
        while (action != 6)
        {
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Remove an entry");
        Console.WriteLine("3. Display");
        Console.WriteLine("4. Load");
        Console.WriteLine("5. Save");
        Console.WriteLine("6. Quit");

            Console.Write("What would you like to do? ");
            action = int.Parse(Console.ReadLine());
            if (action == 1)
            {  
                Entry newEntry = new Entry();
                string newPrompt = prompt.GetRandomPrompt();
                Console.WriteLine(newPrompt);
                string answer = Console.ReadLine();

                DateTime theCurrentTime = DateTime.Now;
                string date = theCurrentTime.ToShortDateString();

                newEntry._promptText = newPrompt;
                newEntry._date = date;
                newEntry._entryText = answer;

                newJournal.AddEntry(newEntry);

                Console.WriteLine("");
                Console.WriteLine("Entry was added!");
                Console.WriteLine("");
            }
            else if (action == 2)
            {
                Console.Write("What number would you want to remove? ");
                string removeText = Console.ReadLine();
                int remove = int.Parse(removeText);
                newJournal.RemoveEntry(remove);
            }
            else if (action == 3)
            {
                newJournal.DisplayAll();
            }
            else if (action == 4)
            {
                Console.WriteLine("What is the filename?");
                string filename = Console.ReadLine();
                newJournal.LoadFromFile(filename);
            }
            else if (action == 5)
            {
                Console.WriteLine("What is the filename? (Use a .txt file)");
                string filename = Console.ReadLine();
                newJournal.SaveToFile(filename);
            }
            else
            {
                break;
            }
        }
    }
}