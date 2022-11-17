using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using luisaMyfirstrazorpages.Data;
using luisaMyfirstrazorpages.Models;

namespace luisaMyfirstrazorpages.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly luisaMyfirstrazorpages.Data.luisaMyfirstrazorpagesContext _context;

        public IndexModel(luisaMyfirstrazorpages.Data.luisaMyfirstrazorpagesContext context)
        {
            _context = context;
        }
        public IList<Movie> Movie { get; set; } = default!;
        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }
        public SelectList? Genres { get; set; }
        [BindProperty(SupportsGet = true)]
        public string? MovieGenre { get; set; }

      

        public async Task OnGetAsync()
        {
            if (_context.Movie != null)
            {
                Movie = await _context.Movie.ToListAsync();
            }
        }
    }
}
