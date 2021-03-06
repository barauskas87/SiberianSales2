using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SiberianSales2.Models;

namespace SiberianSales2.Data
{
    public class SiberianSales2Context : DbContext
    {
        public SiberianSales2Context (DbContextOptions<SiberianSales2Context> options)
            : base(options)
        {
        }

        public DbSet<SiberianSales2.Models.Department> Department { get; set; }
    }
}
