﻿using Microsoft.EntityFrameworkCore;
using SampleProject.Domain.Repository.Entity;
using SampleProject.Infrastructure.Repository.Config;
using SampleProject.Infrastructure.Repository.Seeds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SampleProject.Infrastructure.Repository
{
    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<TaskEntity> Tasks { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        throw new Exception("Banco de dados não configurado");
        //    }
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TaskEntityConfig());

            //foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            //{
            //    relationship.DeleteBehavior = DeleteBehavior.NoAction;
            //}

            modelBuilder.Seed();

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
