using System;

namespace MemeBuilder.Models
{
    public class Template : Entity
    {
        public Template()
            => CreatedOn = DateTime.UtcNow;

        public DateTime CreatedOn { get; private set; }

        public string Description { get; set; }
    }
}
