using API_DesignPartern.Data;
using API_DesignPartern.Entities;
using Microsoft.EntityFrameworkCore;

namespace API_QLDongHo_DesignPartern.Repositories.PhanLoaiRepositories
{
    public class PhanLoaiRepository : IPhanLoaiRepository
    {
        private readonly AppDbContext _DbContext;

        public PhanLoaiRepository(AppDbContext DbContext)
        {
            _DbContext = DbContext;
        }

        public async Task<List<PhanLoai>> GetAllPhanLoaisAsync()
        {
            return await _DbContext.PhanLoais.ToListAsync();
        }

        public async Task<PhanLoai> GetPhanLoaiByIdAsync(Guid id)
        {
            return await _DbContext.PhanLoais.FindAsync(id);
        }


        public async Task AddPhanLoaiAsync(PhanLoai phanLoai)
        {
            await _DbContext.PhanLoais.AddAsync(phanLoai);
            await _DbContext.SaveChangesAsync();
        }

        public async Task UpdatePhanLoaiAsync(PhanLoai phanLoai)
        {
            _DbContext.PhanLoais.Update(phanLoai);
            await _DbContext.SaveChangesAsync();
        }

        public async Task DeletePhanLoaiAsync(Guid id)
        {
            var phanLoai = await _DbContext.PhanLoais.FindAsync(id);
            if (phanLoai != null)
            {
                _DbContext.PhanLoais.Remove(phanLoai);
                await _DbContext.SaveChangesAsync();
            }
        }

    }
}
