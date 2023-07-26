using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp.Pages.Models;

namespace WebApp.Pages.Posts;

public class MaanteeametTimescanner : PageModel
{
    public BasePostPage PostPage { get; set; }
    
    private readonly IWebHostEnvironment _environment;
    
    public MaanteeametTimescanner(IWebHostEnvironment environment)
    {
        _environment = environment;
        var path = Path.Combine(_environment.ContentRootPath, "wwwroot", "static", "content", "MaanteeametTimescanner.md");
        PostPage = new BasePostPage(path);
    }
    
    public void OnGet()
    {

    }
}