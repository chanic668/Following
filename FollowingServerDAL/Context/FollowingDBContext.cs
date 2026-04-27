using System;
using System.Collections.Generic;
using FollowingServerDAL.Models;
using Microsoft.EntityFrameworkCore;

namespace FollowingServerDAL.Context;

public partial class FollowingDBContext : DbContext
{
    public FollowingDBContext(DbContextOptions<FollowingDBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<City> Cities { get; set; }

    public virtual DbSet<Country> Countries { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<City>(entity =>
        {
            entity.HasKey(e => e.CityCode).HasName("PK_tbl_city");

            entity.HasOne(d => d.CountryCodeNavigation).WithMany(p => p.Cities).HasConstraintName("FK_tbl_city_tbl_country");
        });

        modelBuilder.Entity<Country>(entity =>
        {
            entity.HasKey(e => e.CountryCode).HasName("PK_tbl_country");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
