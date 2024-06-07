using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Entities
{
    public class DataContext : DbContext
    {
        public DbSet <Blog> Blogs { get; set; }
        public DbSet<BlogType> BlogTypes { get; set; }
        public DbSet<Post> Posts { get; set; }  
        public DbSet<PostType> PostTypes { get; set; }  
        
        public DbSet<User> Users { get; set; }
        public string Dbpath { get; set; }
        public DataContext()
        {
            var path = AppContext.BaseDirectory;
            Dbpath = Path.Join (path, "Post.db");
        }
        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data source={Dbpath}");
        }
    }
}
