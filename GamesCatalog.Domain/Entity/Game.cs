using GamesCatalog.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamesCatalog.Domain.Entity
{
    public class Game : BaseEntity
    {
        public string Name { get; set; }
        public int TypeId { get; set; }
        public Game(int id, string name, int typeId)
        {
            Id = id;
            Name = name;
            TypeId = typeId;
        }
    }
}
