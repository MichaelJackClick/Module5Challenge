public class Book
{
    // Store the book's title, author, and ISBN.
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }

    // Set the book's information when it is created.
    public Book(string title, string author, string isbn)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
    }

    // Return the book's information as text.
    public override string ToString()
    {
        return $"{Title} by {Author} (ISBN: {ISBN})";
    }
}
