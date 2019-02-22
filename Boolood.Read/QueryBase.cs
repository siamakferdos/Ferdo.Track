using System;
using System.Collections.Generic;
using System.Text;
using Ferdo.Track.Persistence.DbContext;

namespace Ferdo.Track.Read
{
    public class QueryBase
    {
        protected readonly AppDbContext _appDbContext;

        public QueryBase(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
    }
}
