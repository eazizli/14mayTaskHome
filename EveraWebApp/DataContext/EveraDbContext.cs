﻿using EveraWebApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EveraWebApp.DataContext
{
    public class EveraDbContext :IdentityDbContext<AppUser>
    {
        public EveraDbContext(DbContextOptions<EveraDbContext> options) : base(options)
        {

        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Catagory > Catagories { get; set; }
        public DbSet<Popular> Populars { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Setting> Settings { get; set; }    
    }
}
