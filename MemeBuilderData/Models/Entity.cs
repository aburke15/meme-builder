using System;
using MemeBuilderData.Infrastructure;

namespace MemeBuilderData.Models
{
    public abstract class Entity
    {
        protected Entity()
            => Id = GuidComb.GenerateComb().ToString();

        public string Id { get; set; }
    }
}
