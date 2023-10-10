public interface ILibrary
{
    List<IBook> Books { get; set; }
    void AddBook(IBook book);
    void RemoveBook(IBook book);
    void UpdateBook(IBook oldBook, IBook newBook);
    List<IBook> FindBooksByAuthor(string author);
    List<IBook> FindBooksByTitle(string title);
    List<IBook> FindBooksByPublicationDate(DateTime publicationDate);
    List<IBook> FindBooksByPrice(decimal price);
    string ToString();
}

public class Library : ILibrary
{
    public List<IBook> Books { get; set; }

    public Library()
    {
        Books = new List<IBook>()
        {
            new Book() { Title = "Czarne Oceany", Author = "Jacek Dukaj", PublicationDate = new DateTime(2001, 1, 1), Price = 34.99m, Description = "A science fiction novel" },
            new Book() { Title = "Lód", Author = "Jacek Dukaj", PublicationDate = new DateTime(2007, 1, 1), Price = 39.99m, Description = "A science fiction novel" },
            new Book() { Title = "Król Bólu", Author = "Rafał A. Ziemkiewicz", PublicationDate = new DateTime(2018, 1, 1), Price = 29.99m, Description = "A fantasy novel" },
            new Book() { Title = "Człowiek z marmuru", Author = "Andrzej Wajda", PublicationDate = new DateTime(1976, 1, 1), Price = 24.99m, Description = "A drama novel" },
            new Book() { Title = "Pan Tadeusz", Author = "Adam Mickiewicz", PublicationDate = new DateTime(1834, 1, 1), Price = 19.99m, Description = "A national epic" },
            new Book() { Title = "Solaris", Author = "Stanisław Lem", PublicationDate = new DateTime(1961, 1, 1), Price = 22.99m, Description = "A science fiction novel" },
            new Book() { Title = "Nad Niemnem", Author = "Eliza Orzeszkowa", PublicationDate = new DateTime(1888, 1, 1), Price = 29.99m, Description = "A realist novel" },
            new Book() { Title = "Ferdydurke", Author = "Witold Gombrowicz", PublicationDate = new DateTime(1937, 1, 1), Price = 24.99m, Description = "A novel of form" },
            new Book() { Title = "Pamiętniki", Author = "Jan Chryzostom Pasek", PublicationDate = new DateTime(1700, 1, 1), Price = 29.99m, Description = "Historical memoirs" },
            new Book() { Title = "Quo Vadis", Author = "Henryk Sienkiewicz", PublicationDate = new DateTime(1896, 1, 1), Price = 29.99m, Description = "A historical novel" },
        };
    }

    public void AddBook(IBook book)
    {
        Books.Add(book);
    }

    public void RemoveBook(IBook book)
    {
        Books.Remove(book);
    }

    public void UpdateBook(IBook oldBook, IBook newBook)
    {
        int index = Books.IndexOf(oldBook);
        if (index != -1)
        {
            Books[index] = newBook;
        }
    }

    public List<IBook> FindBooksByAuthor(string author)
    {
        return Books.FindAll(book => book.Author == author);
    }

    public List<IBook> FindBooksByTitle(string title)
    {
        return Books.FindAll(book => book.Title == title);
    }

    public List<IBook> FindBooksByPublicationDate(DateTime publicationDate)
    {
        return Books.FindAll(book => book.PublicationDate.Date == publicationDate.Date);
    }

    public List<IBook> FindBooksByPrice(decimal price)
    {
        return Books.FindAll(book => book.Price == price);
    }

    public override string ToString()
    {
        return string.Join("\n", Books.Select(book => book.ToString()));
    }
}
