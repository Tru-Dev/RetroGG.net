using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using RetroGG.net.Models;

namespace RetroGG.net.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Product> Products { get; set; }

        public DbSet<StoredImage> StoredImages { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // Calling base just in case
            base.OnModelCreating(builder);

            builder.Entity<StoredImage>(entity => entity.HasCheckConstraint("CHK_StoredImages_ImageData", $"length(\"ImageData\") <= {1 << 20}"));
        }
    }
}
