﻿using ApplicationCore.Entities;
using Infrastructure.Data.Config;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Infrastructure.Data
{
    public class ShopContext :DbContext
    {
        public ShopContext(DbContextOptions<ShopContext> options) :base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // https://www.learnentityframeworkcore.com/configuration/fluent-api
           // modelBuilder.ApplyConfiguration(new CategoryConfiguration()); //Tek tek bakar
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()); //Tart bulursa çalış

        }
    }
}
