using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp.Pages.Models;

namespace WebApp.Pages.Posts;

public class Charon : PageModel
{
    public BasePostPage PostPage { get; set; }
    
    private readonly IWebHostEnvironment _environment;

    public Charon(IWebHostEnvironment environment)
    {
        _environment = environment;
        var path = Path.Combine(_environment.ContentRootPath, "wwwroot", "content", "Charon.md");
        PostPage = new BasePostPage(path);
    }
    
    public void OnGet()
    {
        
    }
}