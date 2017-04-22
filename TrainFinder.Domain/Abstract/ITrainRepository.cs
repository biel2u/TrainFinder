using System.Collections.Generic;
using TrainFinder.Domain.Entities;

namespace TrainFinder.Domain.Abstract
{
    public interface ITrainRepository
    {
        IEnumerable<Train> Trains { get; }
        void SaveChanges(Train train);
    }
}
