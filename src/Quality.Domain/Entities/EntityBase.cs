using System;
using System.Collections.Generic;
using System.Text;

namespace Quality.Domain.Entities
{
    public abstract class EntityBase
    {
        public string Id { get; protected set; }

        internal EntityBase()
        {
            this.Id = Guid.NewGuid().ToString();
        }
    }
}
