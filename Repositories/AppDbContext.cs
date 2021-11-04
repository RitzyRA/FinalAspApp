using FinalAspApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalAspApp.Repositories
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> opts) : base(opts) { }
        public DbSet<Author> Authors { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Author>().HasData(
                new Author() { Id = 1, Name = "Antanas", Surname = "Vienuolis" },
                new Author() { Id = 2, Name = "Žemaitė" },
                new Author() { Id = 3, Name = "Jonas", Surname = "Biliūnas" }
            );
        }
    }
}
