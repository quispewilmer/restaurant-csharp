#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using restaurant_csharp.Models;

namespace restaurant_csharp.Pages_Movies
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesChefContext _context;

        public DetailsModel(RazorPagesChefContext context)
        {
            _context = context;
        }

        public Chef Chef { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Chef = await _context.Chef.FirstOrDefaultAsync(m => m.Id == id);

            if (Chef == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
