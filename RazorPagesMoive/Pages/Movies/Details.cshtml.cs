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
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesMoive.Models.RazorPagesMoiveContext _context;

        public DetailsModel(RazorPagesMoive.Models.RazorPagesMoiveContext context)
        {
            _context = context;
        }

        public Movie Movie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Movie = await _context.Movie.FirstOrDefaultAsync(m => m.ID == id);

            if (Movie == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
