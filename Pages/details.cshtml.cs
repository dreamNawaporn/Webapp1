using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Webapp1.Pages;

public class detailsModel : PageModel
{
    private readonly ILogger<detailsModel> _logger;

    public detailsModel(ILogger<detailsModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}
