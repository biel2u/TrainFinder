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

        public void SaveChanges (Train train)
        {
            Train dbEntry = context.Trains.Find(train.TrainID);
            if (dbEntry != null)
            {
                dbEntry.Platform = train.Platform;
                dbEntry.Localization = train.Localization;
                dbEntry.Destination = train.Destination;
                dbEntry.Arrival = train.Arrival;
                dbEntry.Departure = train.Departure;
                dbEntry.Status = train.Status;
            }
            context.SaveChanges();
        }
    }
}
