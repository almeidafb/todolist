using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TodoList.Models
{
    public class DataContext : DbContext
    {
        public DataContext() : base("DataContext")
        {
        }

        public DbSet<Task> Tasks { get; set; }
        public DbSet<User> Users { get; set; }
    }
}