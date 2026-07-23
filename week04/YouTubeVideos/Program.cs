using System;

class Program
{
    static void Main(string[] args)
    {
        Video firstVideo = new Video();
        firstVideo._title = "Surviving in Antarctica for 24 hours";
        firstVideo._author = "MrBeast";
        firstVideo._length = "600 seconds";
        firstVideo._videos.Add(firstVideo);

        Comment firstComment = new Comment();
        firstComment._commenter = "Renz Labado";
        firstComment._comment = "Wow, that looks fun!";
        firstVideo.AddToList(firstComment);
        Comment firstComment2 = new Comment();
        firstComment2._commenter = "Aida Labado";
        firstComment2._comment = "That is very scary";
        firstVideo.AddToList(firstComment2);


        
        // / / / / / / / / / / / / / / / / / / / /

        Video secondVideo = new Video();
        secondVideo._title = "Analyzing FUR vs LEV";
        secondVideo._author = "FNS";
        secondVideo._length = "665 seconds";
        secondVideo._videos.Add(secondVideo);

        Comment secondComment = new Comment();
        secondComment._commenter = "LeBron James";
        secondComment._comment = "Great insights!";
        secondVideo.AddToList(secondComment);

        Comment secondComment2 = new Comment();
        secondComment2._commenter = "Kyrie Irving";
        secondComment2._comment = "Wow, LEV almost lost.";
        secondVideo.AddToList(secondComment2);

        Comment secondComment3 = new Comment();
        secondComment3._commenter = "Kevin Love";
        secondComment3._comment = "I love FURIA but they are losing a lot";
        secondVideo.AddToList(secondComment3);

        // / / / / / / / / / / / / // / / // / / 

        Video thirdVideo = new Video();
        thirdVideo._title = "Steph Curry 2026 Season Highlights";
        thirdVideo._author = "NBA";
        thirdVideo._length = "1260 seconds";
        thirdVideo._videos.Add(thirdVideo);

        Comment thirdComment = new Comment();
        thirdComment._commenter = "Felix Labado";
        thirdComment._comment = "The bucket on 5:50, wow.";
        thirdVideo.AddToList(thirdComment);

        Comment thirdComment2 = new Comment();
        thirdComment2._commenter = "Felix Labado";
        thirdComment2._comment = "Steph is insane";
        thirdVideo.AddToList(thirdComment2);

        Comment thirdComment3 = new Comment();
        thirdComment3._commenter = "Carl";
        thirdComment3._comment = "Steph is the GOAT of all point guards.";
        thirdVideo.AddToList(thirdComment3);

        Comment thirdComment4 = new Comment();
        thirdComment4._commenter = "Jacob";
        thirdComment4._comment = "I want to shoot like him.";
        thirdVideo.AddToList(thirdComment4);

        firstVideo.PrintEverything();
        Console.WriteLine("");
        secondVideo.PrintEverything();
        Console.WriteLine("");
        thirdVideo.PrintEverything();
    }
}