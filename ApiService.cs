using System.Text.Json;

public class ApiService
{
    private readonly HttpClient _httpClient;

    public ApiService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<BooksResponse> GetBooksAsync(int quantity = 10, string locale = "en_US", int? seed = null)
    {
        string url = $"https://fakerapi.it/api/v2/books?_quantity={quantity}&_locale={locale}";

        if (seed.HasValue)
            url += $"&_seed={seed.Value}";

        HttpResponseMessage response = await _httpClient.GetAsync(url);

        response.EnsureSuccessStatusCode();

        string json = await response.Content.ReadAsStringAsync();

        return JsonSerializer.Deserialize<BooksResponse>(json);
    }
}
