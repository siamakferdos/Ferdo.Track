using System;
using System.Collections.Generic;
using System.Text;

namespace Ferdo.Track.Model.Dtos
{
    public class DtoBase
    {
        public Guid? Id { get; set; }
        public DateTimeOffset? CreationDate { get; set; }
    }
}
