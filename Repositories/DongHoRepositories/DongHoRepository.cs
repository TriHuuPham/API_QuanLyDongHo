using API_DesignPartern.Data;
using API_DesignPartern.Entities;
using Microsoft.EntityFrameworkCore;

namespace API_DesignPartern.Repositories.DongHoRepositories
{
    public class DongHoRepository : IDongHoRepository
    {
        public readonly AppDbContext _context;

        public DongHoRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<DongHo>> GetAllDongHo()
        {
            return await _context.DongHos.ToListAsync();
        }

        public async Task<DongHo> GetDongHoById(Guid id)
        {
            return await _context.DongHos.FindAsync(id);
        }

        public async Task CreateDongHo(DongHo dongHo)
        {
            _context.DongHos.Add(dongHo);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateDongHo(DongHo dongHo)
        {
            _context.DongHos.Update(dongHo);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteDongHo(Guid id)
        {
            var dongHo = await _context.DongHos.FindAsync(id);
            if (dongHo != null)
            {
                _context.DongHos.Remove(dongHo);
                await _context.SaveChangesAsync();
            }
        }
    }
}
