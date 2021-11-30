using JOBProfile.Core.Entities;
using JOBProfile.Core.Repositories;
using JOBProfile.Infrastructure.Data;
using JOBProfile.Infrastructure.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JOBProfile.Infrastructure.Repositories
{
    public class RecipiesRepository : /*Repository<JOBProfile.Core.Entities.Recipies>*/ IRecipiesRepository
    {
        public Task<Recipies> AddAsync(Recipies entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Recipies entity)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Recipies>> GetAllAsync()
        {
            List<Recipies> recipies = new List<Recipies>();
            recipies.Add(new Recipies()
            {
                Name = "Butter chicken curry",
                CookingInstructions = "Cook well before serving",
                Description = "Best Curry Ever",
                Ingredients = new List<string> { "Butter", "Chicken", "Cream" }
            });
            return recipies;
        }

        public Task<Recipies> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Recipies entity)
        {
            throw new NotImplementedException();
        }
    }
}
