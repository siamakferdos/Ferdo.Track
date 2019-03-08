using System;
using System.Collections.Generic;
using Ferdo.Track.Model.DbModels;

namespace Ferdo.Track.Model.Dtos
{
    public class CenterDto: DtoBase
    {
        public string Name { get; set; }
        public string UserId { get; set; }
        public DateTimeOffset ContractExpireTime { get; set; }
    }
}
