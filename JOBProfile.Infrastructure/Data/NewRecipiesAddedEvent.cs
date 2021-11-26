using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JOBProfile.Infrastructure.Data
{
    public class NewRecipiesAddedEvent : BaseDomainEvent
    {
        public List<string> NewItem { get; set; }
        public NewRecipiesAddedEvent(List<string> newItem)
        {
            NewItem = newItem;
        }
    }
}
