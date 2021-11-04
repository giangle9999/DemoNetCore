using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DemoNetCore.Models;

    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext (DbContextOptions<ApplicationDBContext> options)
            : base(options)
        {
        }

        public DbSet<DemoNetCore.Models.Movie> Movie { get; set; }
    }
