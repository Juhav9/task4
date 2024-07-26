using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPhones.Data;

namespace RazorPhones.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly PhonesContext _phonesContext;
    public IList<Phone>? Phones { get; set; }
    public IndexModel(ILogger<IndexModel> logger
                      ,PhonesContext phonesContext)
    {
        _logger = logger; 
        _phonesContext = phonesContext;
    }

    public async Task OnGet()
    {
        Phones = await _phonesContext.Phones
                               .OrderByDescending(e => e.Modified)
                               .Take(4)
                               .ToListAsync();
    }
}
