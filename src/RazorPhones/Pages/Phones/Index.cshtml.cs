using Microsoft.AspNetCore.Mvc;
using RazorPhones.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace RazorPhones.Pages
{
    public class PhonesModel : PageModel
    {
		private readonly PhonesContext _phonesContext;
		public IList<Phone>? Phones { get; set; }

        public PhonesModel(PhonesContext phonesContext)
        {
            _phonesContext = phonesContext;

        }
		public async Task OnGetAsync()
        {
            Phones = await _phonesContext.Phones
                                   .OrderBy(x => x.Make)
                                   .ThenBy(x => x.Model)
                                   .ToListAsync(); 
        }

    }
}
