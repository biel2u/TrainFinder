using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainFinder.Domain.Entities;
using System.Data.Entity;

namespace TrainFinder.Domain.Concrete
{
    public class EfDbContext : DbContext
    {
        public DbSet<Train> Trains { get; set; }
    }
}
