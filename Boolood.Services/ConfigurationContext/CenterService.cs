using System;
using System.Collections.Generic;
using System.Text;
using Ferdo.Track.Framework.Core.Repository;
using Ferdo.Track.Framework.Core.Services;
using Ferdo.Track.Model.Dtos;
using Ferdo.Track.Model.Mapper;

namespace Ferdo.Track.Services.ConfigurationContext
{
    public class CenterService: ICenterService
    {
        private readonly ICenterRepository _centerRepository;

        public CenterService(ICenterRepository centerRepository)
        {
            _centerRepository = centerRepository;
        }
        public void AddCenter(CenterDto center)
        {
            _centerRepository.AddCenter(center.MapToDbModel());
        }
    }
}
