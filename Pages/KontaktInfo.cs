using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace IBAS_menu.Pages;

public class KontaktModel : PageModel
{
    private readonly ILogger<KontaktModel> _logger;

    public KontaktModel(ILogger<KontaktModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}