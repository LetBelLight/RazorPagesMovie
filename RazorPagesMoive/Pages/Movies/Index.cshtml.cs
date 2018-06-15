using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMoive.Models;
using RazorPagesMovie.Models;

namespace RazorPagesMoive.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesMoive.Models.RazorPagesMoiveContext _context;

        public IndexModel(RazorPagesMoive.Models.RazorPagesMoiveContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
