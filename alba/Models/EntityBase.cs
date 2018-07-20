using System;

namespace alba.Models
{
    public class EntityBase
    {
        public EntityBase()
        {
            CreatedAt = DateTime.Now;
        }
        public string Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
    }
}
