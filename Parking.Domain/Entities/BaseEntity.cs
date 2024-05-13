using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking.Domain.Entities
{
    public abstract class BaseEntity
    {
        public Guid Id { get; private set; }
        public DateTimeOffset CreatedAt { get; private set; } = DateTimeOffset.Now;
        public DateTimeOffset? UpdatedAt { get; protected set; }
        public DateTimeOffset? DeletedAt { get; protected set; }
    }
}
