#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using restaurant_csharp.Models;

    public class RazorPagesChefContext : DbContext
    {
        public RazorPagesChefContext (DbContextOptions<RazorPagesChefContext> options)
            : base(options)
        {
        }

        public DbSet<restaurant_csharp.Models.Chef>? Chef { get; set; }
    }
