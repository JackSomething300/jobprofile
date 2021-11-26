using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JOBProfile.Infrastructure.Data
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        public List<BaseDomainEvent> Events = new List<BaseDomainEvent>();
    }
}
