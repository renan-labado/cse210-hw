using System;

class Program
{
    static void Main(string[] args)
    {
        List<Book> books = new List<Book>();
        Book myBook = new Book();
        myBook._title = "The GOAT";
        myBook._author = "James Ellsworth";
        myBook._yearPublished = 2009;
        myBook._isBorrowed = false;
        books.Add(myBook);

        Book book1 = new Book();
        book1._title = "The Hobbit";
        book1._author = "J.R.R. Tolkien";
        book1._yearPublished = 1937;
        book1._isBorrowed = false;
        books.Add(book1);

        Book book2 = new Book();
        book2._title = "The Hobbit";
        book2._author = "J.R.R. Tolkien";
        book2._yearPublished = 1937;
        book2._isBorrowed = true;
        books.Add(book2);

        Console.WriteLine("Library Books:");
        foreach (Book book in books)
        {
            book.DisplayBook();
            Console.WriteLine("");
        }
    }
}