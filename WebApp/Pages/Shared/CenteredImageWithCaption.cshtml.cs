using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages.Partials;

public class CenteredImageWithCaptionCode : PageModel
{
    public string ImageSrc { get; set; } = "";
    public string ImageCaption { get; set; } = "";
    
    
    public void OnGet()
    {
        
    }
}