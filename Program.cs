using System.Net.Http;

class Program
{
    static async Task Main()
    {
        HttpClient httpClient = new HttpClient();
        ApiService apiService = new ApiService(httpClient);

        BooksResponse result = await apiService.GetBooksAsync(quantity: 5, locale: "en_US", seed: 42);

        Console.WriteLine($"Status: {result.Status} | Code: {result.Code} | Total: {result.Total}");
        Console.WriteLine();

        foreach (Book book in result.Data)
        {
            Console.WriteLine($"[{book.Id}] {book.Title} by {book.Author}");
            Console.WriteLine($"Genre: {book.Genre} | Published: {book.Published} | Publisher: {book.Publisher}");
            Console.WriteLine($"ISBN: {book.Isbn}");
            Console.WriteLine();
        }
    }
}
