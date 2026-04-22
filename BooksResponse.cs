using System.Text.Json.Serialization;

public class BooksResponse
{
    [JsonPropertyName("status")]
    public string Status { get; set; }

    [JsonPropertyName("code")]
    public int Code { get; set; }

    [JsonPropertyName("total")]
    public int Total { get; set; }

    [JsonPropertyName("data")]
    public List<Book> Data { get; set; }
}
