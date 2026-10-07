using System;
using System.Collections.Generic;
using System.Linq;

public class Member
{
    public string Name { get; set; }
    public int ID { get; set; }
    // Keep track of the books this member has borrowed.
    private List<Book> BorrowedBooks { get; set; }

    // Create the member with an empty borrowed book list.
    public Member(string name, int id)
    {
        Name = name;
        ID = id;
        BorrowedBooks = new List<Book>();
    }

    // Move an available book from the library to this member's list.
    public void BorrowBook(Library library, string isbn)
    {
        Book book = library.GetBook(isbn);
        if (book != null)
        {
            BorrowedBooks.Add(book);
            library.RemoveBook(isbn);
            Console.WriteLine($"{Name} borrowed: {book}");
        }
        else
        {
            Console.WriteLine("Book not available.");
        }
    }

    // Move a borrowed book back to the library if the member has it.
    public void ReturnBook(Library library, string isbn)
    {
        Book book = BorrowedBooks.FirstOrDefault(b => b.ISBN == isbn);
        if (book != null)
        {
            BorrowedBooks.Remove(book);
            library.AddBook(book);
            Console.WriteLine($"{Name} returned: {book}");
        }
        else
        {
            Console.WriteLine("Book not found in borrowed list.");
        }
    }

    // Display all books this member has borrowed.
    public void DisplayBorrowedBooks()
    {
        Console.WriteLine($"{Name}'s Borrowed Books:");
        foreach (var book in BorrowedBooks)
        {
            Console.WriteLine(book);
        }
    }
}
