﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace reverseengineexample.Models;

public partial class studdbContext : DbContext
{
    public studdbContext(DbContextOptions<studdbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Stud> Studs { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}