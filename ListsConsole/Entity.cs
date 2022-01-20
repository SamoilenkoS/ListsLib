using System;
using System.Collections.Generic;
using System.Text;

namespace ListsConsole
{//guid: id, string: state, datetime: creationDate
    public class Entity : ICloneable
    {
        public Guid Id { get; set; }
        public string State { get; set; }
        public DateTime CreationDate { get; set; }

        public object Clone()
        {
            return new Entity
            {
                Id = Guid.NewGuid(),
                State = State,
                CreationDate = CreationDate
            };
        }
    }
}
