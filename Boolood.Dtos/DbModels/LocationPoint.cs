using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Ferdo.Track.Model.DbModels
{
    public class LocationPoint: EntityBase
    {
        public string Imei { get; set; }
        public Guid UnderTrackId { get; set; }
        public float Accuracy { get; set; }
        public double Altitude { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public float Speed { get; set; }
        public long Time { get; set; }
    }
}
