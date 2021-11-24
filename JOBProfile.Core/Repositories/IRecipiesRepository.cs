using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JOBProfile.Core.Repositories
{
    public interface IRecipiesRepository: IRepository<JOBProfile.Core.Entities.Recipies>
    {
        Task <IEnumerable <JOBProfile.Core.Entities.Recipies>> GetAllAsync();
    }
}
