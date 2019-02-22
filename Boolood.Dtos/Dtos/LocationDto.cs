using System;


namespace Ferdo.Track.Model.Dtos
{
    public class LocationDto
    {
        public string Imei { get; set; }
        public Guid UnderTrackId { get; set; }
        public string UnderTrackName { get; set; }
        public float Accuracy { get; set; }
        public double Altitude { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public float Speed { get; set; }
        public float Time { get; set; }
        public DateTimeOffset CreationTime { get; set; }
        public string PersianDate { get; set; }
    }
}
