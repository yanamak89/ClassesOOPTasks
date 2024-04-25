using System;
using Task3;


class Program
{
    static void Main(string[] args)
    {
        Book book = new Book();
        
        Console.WriteLine("Enter author of the book: ");
        string author = Console.ReadLine();
        book.SetAuthor(author); 
        
        Console.WriteLine("Enter content: ");
        string content = Console.ReadLine();
        book.SetContent(content);
        
        Console.WriteLine("Enter the title of the book:");
        string title = Console.ReadLine();
        book.SetTitle(title);
        
        book.Show();

    }
}