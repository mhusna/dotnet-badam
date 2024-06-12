using Cnsl_Client;
using System.Net.Http.Json;

Console.WriteLine("API Client");

HttpClient client = new HttpClient();

//string jsonData = client.GetStringAsync("https://localhost:7105/api/Products").Result;
//Console.WriteLine(jsonData);

// JSON De-Serialize
var data = client.GetFromJsonAsync<List<Product>>("https://localhost:7105/api/Products").Result;

foreach (var item in data)
{
    Console.WriteLine(item);
}