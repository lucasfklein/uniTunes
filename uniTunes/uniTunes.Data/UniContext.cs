using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Reflection;
using uniTunes.Models.Models;
using uniTunes.Data.Configuration;

namespace uniTunes.Data
{
    public class UniContext : DbContext
    {
        public UniContext(): base("UnisinosConnectionString")
        {

        }

        public DbSet<Academic> Goals { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Aqui é possível injetar as configurações específicas das classes
            //modelBuilder.Configurations.Add(new ContentConfiguration());
        }
    }
}