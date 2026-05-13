using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace FollowingServerDAL.Context;

public partial class FollowingDBContext : DbContext
{
    public FollowingDBContext(DbContextOptions<FollowingDBContext> options)
        : base(options)
    {
    }

   
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
       
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
