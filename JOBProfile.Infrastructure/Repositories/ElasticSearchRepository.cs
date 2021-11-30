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

        public async Task<Recipies> IndexRecipy(Recipies recipy)
        {
            if (recipy != null)
            {
                await _client.IndexAsync<Recipies>(recipy, x => x.Index("recipies"));
            }

            return recipy;
        }
    }
}
