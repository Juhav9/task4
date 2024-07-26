using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPhones.Data;

namespace RazorPhones.Pages.Phones
{
    public class DeleteModel : PageModel
    {
		private readonly PhonesContext _context;
		public DeleteModel(PhonesContext context)
		{
			_context = context;

		}
		[BindProperty]
		public Phone? Phone { get; set; }
		public async Task<IActionResult> OnGetAsync(int? id)
        {
			if (id == null)
			{
				return NotFound();
			}
			Phone = await _context.Phones
                                  .FirstOrDefaultAsync(p=>p.Id==id);
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

			if (Phone != null) _context.Phones.Remove(Phone);
			await _context.SaveChangesAsync();
			return RedirectToPage("./Index");
		}
	}
}
