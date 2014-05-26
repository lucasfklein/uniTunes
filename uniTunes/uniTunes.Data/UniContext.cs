using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Reflection;
using uniTunes.Data.Configuration;
using uniTunes.Models;

namespace uniTunes.Data
{
    public class UniContext : DbContext
    {
        public UniContext(): base("name=UnisinosConnectionString")
        {
            Database.SetInitializer<UniContext>(new CreateDatabaseIfNotExists<UniContext>());
        }

        public DbSet<Academic> Academics { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Credit> Credits { get; set; }
        public DbSet<Log> Logs { get; set; }
        public DbSet<Media> Medias { get; set; }
        public DbSet<Music> Musics { get; set; }
        public DbSet<Podcast> Podcasts { get; set; }
        public DbSet<Video> Videos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            // Aqui é possível injetar as configurações específicas das classes
            // modelBuilder.Configurations.Add(new ContentConfiguration());

            // Também é possível mudar a convenção padrão
            // modelBuilder.Properties()
            //       .Where(p => p.Name == "Key")
            //       .Configure(p => p.IsKey()); 
        }
    }
}