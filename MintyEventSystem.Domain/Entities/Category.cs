using System;
using System.Collections.Generic;
using MintyEventSystem.Domain.Common;

namespace MintyEventSystem.Domain.Entities
{
    public class Category : AuditableEntity
    {
        public Guid CategoryId { get; set; }
        public string Name { get; set; }
        public ICollection<Event> Events { get; set; }
    }
}