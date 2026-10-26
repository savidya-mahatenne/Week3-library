using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Book
    {
        string Title;
        string Author;
        string ISBN;

        // Example of a constructor that allows us to 'construct' a new
        // Book object
        public Book(string bookTitle, string BookAuthor, string bookISBN)
        {
            this.Title = bookTitle;
            this.Author = BookAuthor;
            this.ISBN = bookISBN;
        }

        void DisplayInfo()
        {
            Console.WriteLine($"Book title: {Title}");
            Console.WriteLine($"Book Author: {Author}");
            Console.WriteLine($"Book ISBN: {ISBN}");
            Console.WriteLine();
        }
    }
}
