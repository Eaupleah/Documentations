using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CSharp.RazorPagesWebApp.Data;
using CSharp.RazorPagesWebApp.Models;

namespace CSharp.RazorPagesWebApp.Pages.Movies
{
    public class CreateModel : PageModel
    {
        private readonly CSharp.RazorPagesWebApp.Data.CSharpRazorPagesWebAppContext _context;

        public CreateModel(CSharp.RazorPagesWebApp.Data.CSharpRazorPagesWebAppContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Movie Movie { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Movie.Add(Movie);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
