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
    public class RecipiesRepository : Repository<JOBProfile.Core.Entities.Recipies>, IRecipiesRepository
    {
        public RecipiesRepository(RecipiesContext recipiesContext): base(recipiesContext)
        {

        }

        Task<IEnumerable<Recipies>> IRecipiesRepository.GetAllAsync()
        {
            throw new NotImplementedException();
        }
    }
}
