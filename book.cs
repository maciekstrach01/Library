public interface IBook
{
    string Title { get; set; }
    string Author { get; set; }
    DateTime PublicationDate { get; set; }
    decimal Price { get; set; }
    string Description { get; set; }
    string ToString();
}

public class Book : IBook
{
    public string Title { get; set; }
    public string Author { get; set; }
    public DateTime PublicationDate { get; set; }
    public decimal Price { get; set; }
    public string Description { get; set; }

    public override string ToString()
    {
        return $"Title: {Title}, Author: {Author}, Publication Date: {PublicationDate}, Price: {Price}, Description: {Description}";
    }
}
