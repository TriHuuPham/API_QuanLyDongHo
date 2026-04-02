using API_DesignPartern.Entities;

namespace API_QLDongHo_DesignPartern.Repositories.ThuongHieuRepositories
{
    public interface IThuongHieuRepository
    {
        Task<List<ThuongHieu>> GetAllThuongHieusAsync();
        Task<ThuongHieu> GetThuongHieuByIdAsync(Guid id);
        Task AddThuongHieuAsync(ThuongHieu thuongHieu);
        Task UpdateThuongHieuAsync(ThuongHieu thuongHieu);
        Task DeleteThuongHieuAsync(Guid id);
    }
}
