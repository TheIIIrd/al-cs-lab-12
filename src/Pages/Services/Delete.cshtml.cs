﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using laboratory_12.Data;
using laboratory_12.Models;

namespace laboratory_12.Pages.Services
{
    public class DeleteModel : PageModel
    {
        private readonly laboratory_12.Data.AppDbContext _context;

        public DeleteModel(laboratory_12.Data.AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Service Service { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var service = await _context.Services.FirstOrDefaultAsync(m => m.Id == id);

            if (service == null)
            {
                return NotFound();
            }
            else
            {
                Service = service;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var service = await _context.Services.FindAsync(id);
            if (service != null)
            {
                Service = service;
                _context.Services.Remove(Service);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
