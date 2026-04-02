using API_DesignPartern.Data;
using API_DesignPartern.Entities;
using Microsoft.EntityFrameworkCore;

namespace API_QLDongHo_DesignPartern.Repositories.NhaCungCapRepositories
{
    public class NhaCungCapRepository : INhaCungCapRepository
    {
        public readonly AppDbContext _DbContext;

        public NhaCungCapRepository(AppDbContext DbContext)
        {
            _DbContext = DbContext;
        }


        public async Task<List<NhaCungCap>> GetAllNhaCungCapsAsync()
        {
            return await _DbContext.NhaCungCaps.ToListAsync();
        }

        public async Task<NhaCungCap> GetNhaCungCapByIdAsync(Guid id)
        {
            return await _DbContext.NhaCungCaps.FindAsync(id);
        }


        public async Task AddNhaCungCapAsync(NhaCungCap nhaCungCap)
        {
            await _DbContext.NhaCungCaps.AddAsync(nhaCungCap);
            await _DbContext.SaveChangesAsync();
        }

        public async Task UpdateNhaCungCapAsync(NhaCungCap nhaCungCap)
        {
            _DbContext.NhaCungCaps.Update(nhaCungCap);
            await _DbContext.SaveChangesAsync();
        }

        public async Task DeleteNhaCungCapAsync(Guid id)
        {
            var nhaCungCap = await _DbContext.NhaCungCaps.FindAsync(id);
            if (nhaCungCap != null)
            {
                _DbContext.NhaCungCaps.Remove(nhaCungCap);
                await _DbContext.SaveChangesAsync();
            }
        }
    }
}
