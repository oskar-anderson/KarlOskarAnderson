using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages.Posts;

public class Sirowa : PageModel
{
    public string Title { get; set; } = "title";
    public string Body { get; set; }
    
    private readonly IWebHostEnvironment _environment;

    public Sirowa(IWebHostEnvironment environment)
    {
        _environment = environment;
    }
    
    
    public async Task OnGet()
    {
        return;
        
        var path = Path.Combine(_environment.ContentRootPath, "wwwroot", "sirowa.json");
        using (var reader = new StreamReader(path))
        {
            var json = reader.ReadToEnd();
            // This does not work - separate modal class is required
            Sirowa items = JsonSerializer.Deserialize<Sirowa>(json);
            Title = items.Title;
            Body = items.Body;
        }
        /*
            
        HttpClient client = new HttpClient();
        HttpResponseMessage response = await client.GetAsync(BASE_URL + "/sirowa.json");
        response.EnsureSuccessStatusCode();
        string responseBody = await response.Content.ReadAsStringAsync();
        PostModel items = JsonSerializer.Deserialize<PostModel>(responseBody);
        Title = items.Title;
        Body = items.Body;
        */ 
    }
}