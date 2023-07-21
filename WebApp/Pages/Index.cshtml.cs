using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp.Pages.Models;

namespace WebApp.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly IWebHostEnvironment _environment;
    public Metadata[] Projects;

    public IndexModel(ILogger<IndexModel> logger, IWebHostEnvironment environment)
    {
        _logger = logger;
        _environment = environment;
        
        var tempsensPath = Path.Combine(_environment.ContentRootPath, "wwwroot", "content", "Tempsens.md");
        using var tempsensReader = new StreamReader(tempsensPath);
        var tempsensMetadata = Metadata.ParseMetadata(tempsensReader.ReadToEnd());
            
        var charonPath = Path.Combine(_environment.ContentRootPath, "wwwroot", "content", "Charon.md");
        using var charonReader = new StreamReader(charonPath);
        var charonMetadata = Metadata.ParseMetadata(charonReader.ReadToEnd());
        
        var maanteeametPath = Path.Combine(_environment.ContentRootPath, "wwwroot", "content", "MaanteeametTimescanner.md");
        using var maanteeametReader = new StreamReader(maanteeametPath);
        var maanteeametMetadata = Metadata.ParseMetadata(maanteeametReader.ReadToEnd());
        

        Projects = new[] { tempsensMetadata, charonMetadata, maanteeametMetadata };
    }

    public void OnGet()
    {
    }
}