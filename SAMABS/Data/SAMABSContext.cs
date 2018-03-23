using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SAMABS.Models
{
    public class SAMABSContext : DbContext
    {
        public SAMABSContext (DbContextOptions<SAMABSContext> options)
            : base(options)
        {
        }

        public DbSet<SAMABS.Models.Product> Product { get; set; }
    }
}
