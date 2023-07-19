using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages.Posts;

public class MaanteeametTimescanner : PageModel
{
    private readonly IWebHostEnvironment _environment;

    public string Content { get; set; } = "";
    
    public MaanteeametTimescanner(IWebHostEnvironment environment)
    {
        _environment = environment;
    }
    
    public void OnGet()
    {
        var path = Path.Combine(_environment.ContentRootPath, "wwwroot", "content", "MaanteeametTimescanner.md");
        using (var reader = new StreamReader(path))
        {
            Content = reader.ReadToEnd();
        }
    }
}