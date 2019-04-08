using System;
// using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace thedashboard.Models
{
    public class UserContext : DbContext
    {
        public DbSet<User> User { get; set; }

        public DbSet<Comments> Comment { get; set; }

        public DbSet<Posts> Post { get; set; }

        public UserContext(DbContextOptions<UserContext> options) : base(options) { }
    }
}