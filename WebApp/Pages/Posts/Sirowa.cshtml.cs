using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages.Posts;

public class Sirowa : PageModel
{
    public string Title { get; set; } = "title";
    public string Body { get; set; }

    public string Content { get; set; } = "";
    
    private readonly IWebHostEnvironment _environment;

    public Sirowa(IWebHostEnvironment environment)
    {
        _environment = environment;
    }
    
    
    public async Task OnGet()
    {
        var path = Path.Combine(_environment.ContentRootPath, "wwwroot", "Posts", "sirowa.md");
        using (var reader = new StreamReader(path))
        {
            Content = reader.ReadToEnd();
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