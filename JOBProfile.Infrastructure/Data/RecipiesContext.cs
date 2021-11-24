using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JOBProfile.Infrastructure.Data
{
    public class RecipiesContext : DbContext
    {
        public RecipiesContext(DbContextOptions<RecipiesContext> options) : base(options) { }
        public DbSet<JOBProfile.Core.Entities.Recipies> Recipies
        {
            get;
            set;
        }
    }
}
