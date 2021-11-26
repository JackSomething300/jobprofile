using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JOBProfile.Infrastructure.Data
{
    public class DBRecipies: BaseEntity
    {
        public string Name { get; set; }
        private List<List<string>> _items = new List<List<string>>();
        public IEnumerable<List<string>> Ingredients => _items.AsReadOnly();

        public void AddItem(List<string> newItem)
        {
            _items.Add(newItem);

            var newItemAddedEvent = new NewRecipiesAddedEvent(newItem);
            Events.Add(newItemAddedEvent);
        }
    }
}
