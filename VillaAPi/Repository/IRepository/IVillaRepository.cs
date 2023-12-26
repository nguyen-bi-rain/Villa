using System.Linq.Expressions;
using VillaAPi.Models;

namespace VillaAPi.Repository.IRepository
{
    public interface IVillaRepository : IRepository<Villa>
    {
        
        Task<Villa> Update(Villa entity);
     
    }
}
