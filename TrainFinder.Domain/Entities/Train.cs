using System;

namespace TrainFinder.Domain.Entities
{
    public class Train
    {
        public int TrainID { get; set; }
        public int Number { get; set; }
        public int Platform { get; set; }
        public string Localization { get; set; }
        public string Destination { get; set; }
        public TimeSpan Arrival { get; set; }
        public TimeSpan Departure { get; set; }
        public string Status { get; set; }
    }
}
