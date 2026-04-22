using System.Text.Json.Serialization;

public class Book
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("title")]
    public string Title { get; set; }

    [JsonPropertyName("author")]
    public string Author { get; set; }

    [JsonPropertyName("genre")]
    public string Genre { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("isbn")]
    public string Isbn { get; set; }

    [JsonPropertyName("published")]
    public string Published { get; set; }

    [JsonPropertyName("publisher")]
    public string Publisher { get; set; }
}
