﻿using System;

namespace Ferdo.Track.Model.DbModels
{
    public abstract class EntityBase
    {
        public Guid Id { get; set; }
        public DateTimeOffset CreationDate { get; set; }

        protected EntityBase()
        {
            Id = Guid.NewGuid();
            CreationDate = DateTime.Now;
        }
    }
}
