﻿using Microsoft.EntityFrameworkCore;

namespace MovieWebAppProject.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {

        }

        public DbSet<Movie> Movies { get; set; }
    }
}
