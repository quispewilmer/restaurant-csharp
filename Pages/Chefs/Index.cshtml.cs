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
    public class IndexModel : PageModel
    {
        private readonly RazorPagesChefContext _context;

        public IndexModel(RazorPagesChefContext context)
        {
            _context = context;
        }

        public IList<Chef> Chef { get;set; }

        public async Task OnGetAsync()
        {
            Chef = await _context.Chef.ToListAsync();
        }
    }
}
