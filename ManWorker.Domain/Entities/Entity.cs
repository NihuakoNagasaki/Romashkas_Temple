using System;

namespace ManWorker.Domain.Entities
{
    public class Entity
    {
        public Guid Id { get; set; }

        public DateTime UpdateTime { get; set; }

        public DateTime IsDeleted { get; set; }
    }
}
