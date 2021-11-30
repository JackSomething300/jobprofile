using JOBProfile.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JOBProfile.Core.Repositories
{
    public interface IElasticSearchProvider
    {
        Task<List<Recipies>> GetAllRecipies();
        Task<Recipies> IndexRecipy(Recipies recipies);
    }
}
