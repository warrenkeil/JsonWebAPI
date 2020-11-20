using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JsonWebAPI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace JsonWebAPI.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<Person> People { get; set; }
    }
}
