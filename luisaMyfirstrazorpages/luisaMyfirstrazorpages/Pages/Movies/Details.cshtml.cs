using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using luisaMyfirstrazorpages.Data;
using luisaMyfirstrazorpages.Models;

namespace luisaMyfirstrazorpages.Pages.Movies
{
    public class DetailsModel : PageModel
    {
        private readonly luisaMyfirstrazorpages.Data.luisaMyfirstrazorpagesContext _context;

        public DetailsModel(luisaMyfirstrazorpages.Data.luisaMyfirstrazorpagesContext context)
        {
            _context = context;
        }

      public Movie Movie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Movie == null)
            {
                return NotFound();
            }

            var movie = await _context.Movie.FirstOrDefaultAsync(m => m.ID == id);
            if (movie == null)
            {
                return NotFound();
            }
            else 
            {
                Movie = movie;
            }
            return Page();
        }
    }
}
