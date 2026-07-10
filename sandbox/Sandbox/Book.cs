using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

public class Book
{
    public string _title;
    public string _author;
    public int _yearPublished;
    public bool _isBorrowed = false;
    public void DisplayBook()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Year: {_yearPublished}");
        if (_isBorrowed == false)
        {
            Console.WriteLine("Status: Available");
        }
        else
        {
            Console.WriteLine("Status: Borrowed");
        }
    }
    public void BorrowBook()
    {
        _isBorrowed = true;
    }
}