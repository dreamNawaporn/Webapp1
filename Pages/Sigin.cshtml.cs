using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Webapp1.Pages;

public class SiginModel : PageModel
{
    private readonly ILogger<SiginModel> _logger;

    public SiginModel(ILogger<SiginModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}


