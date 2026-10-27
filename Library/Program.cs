using Library;
class Program
{
    static void Main(string[] args)
    {
        // Create a new instance (object) of the Book class
        // Note how the object name differs from the class name
        Book book = new Book("C# for beginners", "Bill Gates", "1234567");
        Book book1 = new Book("Ultimate C#", "Microsoft", "2233445");
        Console.WriteLine("Currently available books");
        book.DisplayInfo();
        book1.DisplayInfo();

        // Create new instances of the Member Class
        // These new members are created using
        // Member consrtructor in the Member class
        Member member = new Member(1, "John Smith", "1 High Street", "0790090090");
        Member member1 = new Member(2, "Mary Jones", "102 Garden Road", "0790345666");

        Console.WriteLine("Current library members");
        member.DisplayInfo();
        member1.DisplayInfo();

        // Testing the validation logic with invalid data
        Member invalidMember = new Member(-5, "Rob0t C0p", "50 Main Street", "07811223344");
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

