using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesPrabesh.Models;

namespace RazorPagesPrabesh.Data
{
    public class RazorPagesPrabeshContext : DbContext
    {
        public RazorPagesPrabeshContext (DbContextOptions<RazorPagesPrabeshContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesPrabesh.Models.Movie> Movie { get; set; } = default!;
    }
}
