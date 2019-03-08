using System;
using System.Collections.Generic;
using Ferdo.Track.Model.DbModels;

namespace Ferdo.Track.Model.Dtos
{
    public class UnderTrackGroupMemberDto: DtoBase
    {
        public Guid GroupId { get; set; }
        public string GroupNameName { get; set; }
        public Guid UnderTrackId { get; set; }
        public string UnserTrackName { get; set; }
        
    }
}
