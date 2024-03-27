using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesPrabesh.Data;
using RazorPagesPrabesh.Models;

namespace RazorPagesPrabesh.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesPrabesh.Data.RazorPagesPrabeshContext _context;

        public IndexModel(RazorPagesPrabesh.Data.RazorPagesPrabeshContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
