using System.ComponentModel.DataAnnotations;

public class Video
{
    public string _title;
    public string _author;
    public string _length;
    public List<Comment> _comments = new List<Comment>();
    public List<Video> _videos = new List<Video>();


    public int CommentCount()
    {
        return _comments.Count();
    }

    public void AddToList(Comment newComment) // stores the comment to a list
    {
        _comments.Add(newComment);
    }

    public void PrintEverything()
    {
        Console.WriteLine($"{_title}");
        Console.WriteLine($"{_author}");
        Console.WriteLine($"{_length}");
        Console.WriteLine($"Number of comments: {CommentCount()}");

        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }
    }
}