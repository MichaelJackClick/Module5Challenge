using System;
using System.Collections.Generic;
using System.Linq;

public class Library
{
    public string Name { get; set; }
    // Keep the list of available books private.
    private List<Book> Books { get; set; }

    // Create the library with an empty book list.
    public Library(string name)
    {
        Name = name;
        Books = new List<Book>();
    }

    // Add a book to the library.
    public void AddBook(Book book)
    {
        Books.Add(book);
        Console.WriteLine($"Added: {book}");
    }

    // Find a book by ISBN and remove it if it is available.
    public bool RemoveBook(string isbn)
    {
        Book bookToRemove = Books.FirstOrDefault(b => b.ISBN == isbn);
        if (bookToRemove != null)
        {
            Books.Remove(bookToRemove);
            Console.WriteLine($"Removed: {bookToRemove}");
            return true;
        }
        Console.WriteLine("Book not found.");
        return false;
    }

    // Display every book currently in the library.
    public void DisplayAvailableBooks()
    {
        Console.WriteLine("Available Books:");
        foreach (var book in Books)
        {
            Console.WriteLine(book);
        }
    }

    // Look up a book by ISBN, returning null when it is not found.
    public Book GetBook(string isbn)
    {
        return Books.FirstOrDefault(b => b.ISBN == isbn);
    }
}
