using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using luisaMyfirstrazorpages.Models;

namespace luisaMyfirstrazorpages.Data
{
    public class luisaMyfirstrazorpagesContext : DbContext
    {
        public luisaMyfirstrazorpagesContext (DbContextOptions<luisaMyfirstrazorpagesContext> options)
            : base(options)
        {
        }

        public DbSet<luisaMyfirstrazorpages.Models.Movie> Movie { get; set; } = default!;
    }
}
