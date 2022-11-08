using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using pingpong.Models;

    public class pingpongContext : DbContext
    {
        public pingpongContext (DbContextOptions<pingpongContext> options)
            : base(options)
        {
        }

        public DbSet<pingpong.Models.Player> Player { get; set; } = default!;
        public DbSet<pingpong.Models.Game> Game { get; set; } = default!;
    }
