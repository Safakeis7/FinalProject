﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FinalProject.Models;

namespace FinalProject.Data
{
    public class FinalProjectContext : DbContext
    {
        public FinalProjectContext (DbContextOptions<FinalProjectContext> options)
            : base(options)
        {
        }

        public DbSet<FinalProject.Models.Students> Students { get; set; } = default!;
        public DbSet<FinalProject.Models.Cartoon> Cartoon { get; set; } = default!;
        public DbSet<FinalProject.Models.Songs> Songs { get; set; } = default!;
        public DbSet<FinalProject.Models.BasketballTeams> BasketballTeams { get; set; } = default!;
        public DbSet<FinalProject.Models.Hobby> Hobby { get; set; } = default!;

    }
}
