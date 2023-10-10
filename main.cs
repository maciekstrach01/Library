class Program
{
    static void Main(string[] args)
    {
        Library library = new Library();
        
        while (true)
        {
            Console.WriteLine("1. Add book");
            Console.WriteLine("2. Remove book");
            Console.WriteLine("3. Update book");
            Console.WriteLine("4. Find books by author");
            Console.WriteLine("5. Find books by title");
            Console.WriteLine("6. Find books by publication date");
            Console.WriteLine("7. Find books by price");
            Console.WriteLine("8. Display all books");
            Console.WriteLine("9. Exit");

            string choice = Console.ReadLine();
            try
            {
                switch (choice)
                {
                    case "1":
                        // Logic to add a book
                        Console.WriteLine("Enter book details (title, author, publication date, price, description):");
                        Book newBook = new Book
                        {
                            Title = Console.ReadLine(),
                            Author = Console.ReadLine(),
                            PublicationDate = DateTime.Parse(Console.ReadLine()),
                            Price = decimal.Parse(Console.ReadLine()),
                            Description = Console.ReadLine()
                        };
                        library.AddBook(newBook);
                        break;
                    case "2":
                        // Logic to remove the book
                        Console.WriteLine("Enter title of the book to remove:");
                        string titleToRemove = Console.ReadLine();
                        Book bookToRemove = library.FindBooksByTitle(titleToRemove).FirstOrDefault() as Book;
                        if (bookToRemove != null)
                        {
                            library.RemoveBook(bookToRemove);
                        }
                        else
                        {
                            Console.WriteLine("Book not found.");
                        }
                        break;
                    case "3":
                        // Logic to update the book
                        Console.WriteLine("Enter title of the book to update:");
                        string titleToUpdate = Console.ReadLine();
                        Book oldBook = library.FindBooksByTitle(titleToUpdate).FirstOrDefault() as Book;
                        if (oldBook != null)
                        {
                            Console.WriteLine("Enter new book details (title, author, publication date, price, description):");
                            Book newBookToUpdate = new Book
                            {
                                Title = Console.ReadLine(),
                                Author = Console.ReadLine(),
                                PublicationDate = DateTime.Parse(Console.ReadLine()),
                                Price = decimal.Parse(Console.ReadLine()),
                                Description = Console.ReadLine()
                            };
                            library.UpdateBook(oldBook, newBookToUpdate);
                        }
                        else
                        {
                            Console.WriteLine("Book not found.");
                        }
                        break;
                    case "4":
                        // Logic to search for books by author
                        Console.WriteLine("Enter author's name:");
                        string author = Console.ReadLine();
                        List<IBook> booksByAuthor = library.FindBooksByAuthor(author);
                        foreach (IBook book in booksByAuthor)
                        {
                            Console.WriteLine(book);
                        }
                        break;
                    case "5":
                        // Logic for finding books by title
                        Console.WriteLine("Enter title:");
                        string title = Console.ReadLine();
                        List<IBook> booksByTitle = library.FindBooksByTitle(title);
                        foreach (IBook book in booksByTitle)
                        {
                            Console.WriteLine(book);
                        }
                        break;
                    case "6":
                        // Logic for searching books by publication date
                        Console.WriteLine("Enter publication date (yyyy-mm-dd):");
                        DateTime publicationDate = DateTime.Parse(Console.ReadLine());
                        List<IBook> booksByDate = library.FindBooksByPublicationDate(publicationDate);
                        foreach (IBook book in booksByDate)
                        {
                            Console.WriteLine(book);
                        }
                        break;
                    case "7":
                        // Logic for finding books by price
                        Console.WriteLine("Enter price:");
                        decimal price = decimal.Parse(Console.ReadLine());
                        List<IBook> booksByPrice = library.FindBooksByPrice(price);
                        foreach (IBook book in booksByPrice)
                        {
                            Console.WriteLine(book);
                        }
                        break;
                    case "8":
                        // Display of all books
                        Console.WriteLine(library.ToString());
                        break;
                    case "9":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number from 1 to 9.");
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"An error occurred: {e.Message}");
            }
        }
    }
}


