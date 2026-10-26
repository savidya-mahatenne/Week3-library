using Library;
class Program
{
    static void Main(string[] args)
    {
        // Create a new instance (object) of the Book class
        // Note how the object name differs from the class name
        Book book = new Book("C# for beginners", "Bill Gates", "1234567");

        book.DisplayInfo();
    }
}





/*
 * 21T Introduction to Classes and Objects (with GitHub sync)
 * code: 
 * 
Book book = new Book();
// This information is for one book in our library
book.Title = "C# for beginners";
book.Author = "BillGates";
book.ISBN = "12345678";

book.DisplayInfo();

// This is another book in our library
Book book1 = new Book();
book1.Title = "C# Methods and classes";
book1.Author = "Microsoft";
book1.ISBN = "55667778";

book1.DisplayInfo();
*/

