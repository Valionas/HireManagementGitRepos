﻿using HireManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HireManagement.Data
{
    public class HireContext:DbContext
    {
        public HireContext(DbContextOptions<HireContext> options) : base(options)
        {

        }

        public DbSet<Contract> Contracts { get; set; }                    
        public DbSet<Recruitment> Recruitments { get; set; }
        public DbSet<Worker> Workers { get; set; }
        public object Contract { get; internal set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contract>().ToTable("Contract");
            modelBuilder.Entity<Recruitment>().ToTable("Recruitment");           //Changing table names in singular form
            modelBuilder.Entity<Worker>().ToTable("Worker");
        }

    }
}
