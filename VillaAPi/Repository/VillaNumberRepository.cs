using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using VillaAPi.Data;
using VillaAPi.Models;
using VillaAPi.Repository.IRepository;

namespace VillaAPi.Repository
{
    public class VillaNumberRepository : Repository<VillaNumber>, IVillaNumberRepository
    {
        private readonly ApplicationDbContext _db;

        public VillaNumberRepository(ApplicationDbContext db) : base(db) 
        {
            _db = db;
        }

        public async Task<VillaNumber> UpdateAsync(VillaNumber entity)
        {
            entity.UpdatedDate = DateTime.Now;
            _db.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
