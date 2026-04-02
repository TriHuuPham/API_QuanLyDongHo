using API_DesignPartern.Entities;

namespace API_QLDongHo_DesignPartern.Repositories.PhanLoaiRepositories
{
    public interface IPhanLoaiRepository
    {
        Task<List<PhanLoai>> GetAllPhanLoaisAsync();
        Task<PhanLoai> GetPhanLoaiByIdAsync(Guid id);
        Task AddPhanLoaiAsync(PhanLoai phanLoai);
        Task UpdatePhanLoaiAsync(PhanLoai phanLoai);
        Task DeletePhanLoaiAsync(Guid id);
    }
}
