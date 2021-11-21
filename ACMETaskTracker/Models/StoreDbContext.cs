using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ACMETaskTracker.Models
{
    public class StoreDbContext: DbContext
    {
        public StoreDbContext(DbContextOptions<StoreDbContext> options) : base(options) { }
        public DbSet<AcmeTask> Tasks { get; set; }
    }
}
