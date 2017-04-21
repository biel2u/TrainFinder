using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainFinder.Domain.Abstract;
using TrainFinder.Domain.Entities;

namespace TrainFinder.Domain.Concrete
{
    public class EfTrainRepository : ITrainRepository
    {
        private EfDbContext context = new EfDbContext();
        public IEnumerable<Train> Trains
        {
           get { return context.Trains; }
        }

    }
}
