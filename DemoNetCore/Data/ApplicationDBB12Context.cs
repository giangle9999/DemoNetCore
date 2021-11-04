using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DemoNetCore.Models;

    public class ApplicationDBB12Context : DbContext
    {
        public ApplicationDBB12Context (DbContextOptions<ApplicationDBB12Context> options)
            : base(options)
        {
        }

        public DbSet<DemoNetCore.Models.Demo> Demo { get; set; }
    }
