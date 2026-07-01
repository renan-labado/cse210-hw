using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.WriteLine("");
        Console.Write("Grade Percentage: ");
        string gradePercentageText = Console.ReadLine();
        int grade = int.Parse(gradePercentageText);
        string letter = "";
        Console.WriteLine("");
        if (grade >= 90)
        {
            if (grade >= 97)
            {
                letter = "A";
            }
            else if (grade < 93)
            {
                letter = "A-";
            }
            else
            {
                letter = "A";
            }
        }
        else if (grade >= 80)
        {
            if (grade >= 87)
            {
                letter = "B+";
            }
            else if (grade < 83)
            {
                letter = "B-";
            }
            else
            {
                letter = "B";
            }
        }
        else if (grade >= 70)
        {
            if (grade >= 77)
            {
                letter = "C+";
            }
            else if (grade < 73)
            {
                letter = "C-";
            }
            else
            {
                letter = "C";
            }
        }
        else if (grade >= 60)
        {
            if (grade >= 67)
            {
                letter = "D+";
            }
            else if (grade < 63)
            {
                letter = "D-";
            }
            else
            {
                letter = "D";
            }
        }
        else
        {
            if (grade >= 57)
            {
                letter = "F+";
            }
            else if (grade < 53 && grade > 50)
            {
                letter = "F-";
            }
            else
            {
                letter = "F";
            }
        }
        if (grade >= 70)
        {
            Console.WriteLine($"Your grade is {letter}");
            Console.WriteLine("Congratulations, you passed the course!");
        }
        else
        {
            Console.WriteLine($"Your grade is {letter}");
            Console.WriteLine("Sadly, you failed the course, but you can try again!");
        }
    }
}