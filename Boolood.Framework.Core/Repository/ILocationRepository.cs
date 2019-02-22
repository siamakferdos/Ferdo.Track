using System;
using System.Collections.Generic;
using System.Text;
using Ferdo.Track.Model.DbModels;

namespace Ferdo.Track.Framework.Repository
{
    public interface ILocationRepository
    {
        void AddLocationPoints(List<LocationPoint> locationPoint);
    }
}
