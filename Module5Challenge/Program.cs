using System;

class Program
{
    static void Main(string[] args)
    {
        Library library = new Library("Central Library");
        Member member1 = new Member("Alice", 1);
        Member member2 = new Member("Bob", 2);

        // Adding books to the library
        library.AddBook(new Book("The Great Gatsby", "F. Scott Fitzgerald", "9780743273565"));
        library.AddBook(new Book("To Kill a Mockingbird", "Harper Lee", "9780446310789"));
        library.AddBook(new Book("1984", "George Orwell", "9780451524935"));

        // Displaying available books
        library.DisplayAvailableBooks();

        Console.WriteLine("\nBorrowing books:");
        member1.BorrowBook(library, "9780743273565");
        member2.BorrowBook(library, "9780446310789");

        // Displaying available books after borrowing
        library.DisplayAvailableBooks();

        // Displaying borrowed books for members
        member1.DisplayBorrowedBooks();
        member2.DisplayBorrowedBooks();

        Console.WriteLine("\nReturning a book:");
        member1.ReturnBook(library, "9780743273565");

        // Final display of available books
        library.DisplayAvailableBooks();
    }
}
