using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DemoMVC.Models;

namespace DemoMVC.Data
{
    public class DemoMVCContext : DbContext
    {
        public DemoMVCContext (DbContextOptions<DemoMVCContext> options)
            : base(options)
        {
        }

        public DbSet<DemoMVC.Models.Filme> Filme { get; set; } = default!;
    }
}
