using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlogApp.Entities;

namespace BlogApp.DBContexts
{
    public class BlogContext:DbContext
    {
        public string connectionString = @"Data Source=DESKTOP-RQSMQ1M\SQLEXPRESS;Initial Catalog=tfl;Integrated Security=True;Connect Timeout=30;Encrypt=False";

        public DbSet<Author> Author { get; set; }
        public DbSet<Blog> Blog { get; set; }

        public DbSet<Post> Post { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
