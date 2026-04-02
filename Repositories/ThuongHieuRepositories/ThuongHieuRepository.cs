using API_DesignPartern.Data;
using API_DesignPartern.Entities;
using Microsoft.EntityFrameworkCore;

namespace API_QLDongHo_DesignPartern.Repositories.ThuongHieuRepositories
{
    public class ThuongHieuRepository : IThuongHieuRepository
    {
        private readonly AppDbContext _DbContext;

        public ThuongHieuRepository(AppDbContext DbContext)
        {
            _DbContext = DbContext;
        }

        public async Task<List<ThuongHieu>> GetAllThuongHieusAsync()
        {
            return await _DbContext.ThuongHieus.ToListAsync();
        }

        public async Task<ThuongHieu> GetThuongHieuByIdAsync(Guid id)
        {
            return await _DbContext.ThuongHieus.FindAsync(id);
        }

        public async Task AddThuongHieuAsync(ThuongHieu thuongHieu)
        {
            await _DbContext.ThuongHieus.AddAsync(thuongHieu);
            await _DbContext.SaveChangesAsync();
        }

        public async Task UpdateThuongHieuAsync(ThuongHieu thuongHieu)
        {
            _DbContext.ThuongHieus.Update(thuongHieu);
            await _DbContext.SaveChangesAsync();
        }

        public async Task DeleteThuongHieuAsync(Guid id)
        {
            var thuongHieu = await _DbContext.ThuongHieus.FindAsync(id);
            if (thuongHieu != null)
            {
                _DbContext.ThuongHieus.Remove(thuongHieu);
                await _DbContext.SaveChangesAsync();
            }
        }
    }
}
