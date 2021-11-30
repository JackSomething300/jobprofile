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
        private readonly IElasticSearchProvider _elasticSearchProvider;

        public RecipiesRepository(IElasticSearchProvider elasticSearchProvider)
        {
            _elasticSearchProvider = elasticSearchProvider;
        }
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
            var recipies = await _elasticSearchProvider.GetAllRecipies();
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
