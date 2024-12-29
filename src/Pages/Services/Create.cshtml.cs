using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using laboratory_12.Data;
using laboratory_12.Models;

namespace laboratory_12.Pages.Services
{
    public class CreateModel : PageModel
    {
        private readonly laboratory_12.Data.AppDbContext _context;

        public CreateModel(laboratory_12.Data.AppDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Service Service { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Services.Add(Service);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
