using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JOBProfile.Core.Entities
{
    public class Recipies
    {
        public Recipies() => Ingredients = new List<string>();

        public List<string> Ingredients { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CookingInstructions { get; set; }
    }
}
