using GraphqlApiProject.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphqlApiProject.ApplicationContext
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options)
           : base(options)
        {
        }
        public DbSet<Author> Authors { get; set; }  //Similar to ItemList  calles List
        public DbSet<Course> Courses { get; set; }   // //Similar to ItemData called Items
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}

