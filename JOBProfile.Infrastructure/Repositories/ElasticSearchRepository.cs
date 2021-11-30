using JOBProfile.Core.Entities;
using JOBProfile.Core.Repositories;
using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JOBProfile.Infrastructure.Repositories
{
    public class ElasticSearchRepository : IElasticSearchProvider
    {
        private readonly ElasticClient _client;
        public ElasticSearchRepository(ElasticClient client)
        {
            _client = client;
        }
        public async Task<List<Recipies>> GetAllRecipies()
        {
            var result = await _client.SearchAsync<Recipies>(x => x.Size(10)
            .From(0)
            .Query(q=> q.MatchAll())
            .Index("recipies"));
            return result.Documents.ToList();
        }

        public async Task IndexRecipy()
        {
           var recipy = new Recipies()
            {
               Name = "Cottage Pie",
               CookingInstructions = "Cook well before serving",
               Description = "Best Pie Ever",
               Ingredients = new List<string> { "Cellery", "Minse", "Beef Stock" }
           };

            await _client.IndexAsync<Recipies>(recipy, x => x.Index("recipies"));

        }
    }
}
