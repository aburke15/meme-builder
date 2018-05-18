using System;
using MemeBuilderData.Infrastructure;

namespace MemeBuilderData.Models
{
    public abstract class Entity
    {
        protected Entity()
            => Id = GuidComb.GenerateComb();

        public Guid Id { get; private set; }
    }
}
