using System;
using System.Collections.Generic;
using Ferdo.Track.Model.DbModels;

namespace Ferdo.Track.Model.Dtos
{
    public class UnderTrackGroupDto: DtoBase
    {
        public Guid CenterId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
