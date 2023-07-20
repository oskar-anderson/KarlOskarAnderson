using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp.Pages.Models;

namespace WebApp.Pages.Posts;

public class Tempsens : PageModel
{
    public BasePostPage PostPage { get; set; }
    
    private readonly IWebHostEnvironment _environment;

    public Tempsens(IWebHostEnvironment environment)
    {
        _environment = environment;
        var path = Path.Combine(_environment.ContentRootPath, "wwwroot", "content", "Tempsens.md");
        PostPage = new BasePostPage(path);
    }
    
    
    public void OnGet()
    {
        
    }
}