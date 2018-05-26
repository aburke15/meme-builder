using System;
using MemeBuilder.Infrastructure;

namespace MemeBuilder.Models
{
    public abstract class Entity
    {
        protected Entity()
            => Id = GuidComb.GenerateComb();

        public Guid Id { get; private set; }
    }
}
