using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using VillaAPi.Data;
using VillaAPi.Models;
using VillaAPi.Repository.IRepository;

namespace VillaAPi.Repository
{
    public class VillaRepository : Repository<Villa>, IVillaRepository
    {
        private readonly ApplicationDbContext _db;

        public VillaRepository(ApplicationDbContext db) : base(db) 
        {
            _db = db;
        }

        public async Task<Villa> Update(Villa entity)
        {
            entity.UpdatedDate = DateTime.Now;
            _db.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
