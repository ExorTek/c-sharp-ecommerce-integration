﻿using Entities.Abstract;

namespace Entities.Concrete
{
    public class Districts:IEntity
    {
        public int Id { get; set; }
        public int TownId { get; set; }
        public string District { get; set; }
    }
}
