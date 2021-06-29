using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace testBits.Models
{
    public class CSVContext: DbContext
    {
        public DbSet<CSV> CSVs { get; set; }
        public CSVContext(DbContextOptions<CSVContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
