using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using RazorPhones.Data;

namespace RazorPhones.Pages.Phones
{
    public class EditModel : PageModel
    {
		private readonly PhonesContext _context;
		//public IList<Phone>? Phone { get; set; }

		[BindProperty]
		public Phone? Phone { get; set; }
		public EditModel(PhonesContext context)
		{
			_context = context;

		}
		public async Task<IActionResult> OnGetAsync(int? id)
        {
			if (id == null)
			{
				NotFound();
			}
            Phone = _context.Phones.FirstOrDefault(e => e.Id == id);
			if (Phone == null)
			{
				return NotFound();
			}
			return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {
			if (!ModelState.IsValid)
			{
				return Page();
			}

			if (Phone != null) _context.Phones.Update(Phone);
			await _context.SaveChangesAsync();
			return RedirectToPage("./Index");
		}
    }

}
