using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Assignment13.Models;

namespace Assignment13.Data
{
    public class Assignment13Context : DbContext
    {
        public Assignment13Context (DbContextOptions<Assignment13Context> options)
            : base(options)
        {
        }

        public DbSet<Assignment13.Models.Employee> Employee { get; set; }
    }
}
