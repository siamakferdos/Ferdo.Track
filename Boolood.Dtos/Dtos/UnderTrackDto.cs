using System;
using Ferdo.Track.Model.DbModels;

namespace Ferdo.Track.Model.Dtos
{
    public class UnderTrackDto: DtoBase
    {
        public string Name { get; set; }
        public Guid? UnderTrackTypeId { get; set; }
        public Guid CenterId { get; set; }
        public string UnderTrackTypeName { get; set; }
        public string Imei { get; set; }
        public string CellNumber { get; set; }


    }
}
