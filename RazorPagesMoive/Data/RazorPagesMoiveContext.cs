using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;

namespace RazorPagesMoive.Models
{
    public class RazorPagesMoiveContext : DbContext
    {
        public RazorPagesMoiveContext (DbContextOptions<RazorPagesMoiveContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMovie.Models.Movie> Movie { get; set; }
    }
}
