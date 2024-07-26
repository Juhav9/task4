using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPhones.Data;

namespace RazorPhones.Pages.Phones
{
    public class AddModel : PageModel
    {
		private readonly Data.PhonesContext _context;

        public AddModel(Data.PhonesContext context)
        {
            _context = context; 
        }
		public void OnGet()
        {

        }

        [BindProperty]
        public Phone? Phone { get; set; }
        public async Task<IActionResult> OnPostAsync() {

            if (!ModelState.IsValid)
            {
                return Page();  
            }

            if(Phone != null) _context.Phones.Add(Phone);
            await _context.SaveChangesAsync();
			return RedirectToPage("./Index");
        }
    }
}
