using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CSharp.RazorPagesWebApp.Models;

namespace CSharp.RazorPagesWebApp.Data
{
    public class CSharpRazorPagesWebAppContext : DbContext
    {
        public CSharpRazorPagesWebAppContext (DbContextOptions<CSharpRazorPagesWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<CSharp.RazorPagesWebApp.Models.Movie> Movie { get; set; } = default!;
    }
}
