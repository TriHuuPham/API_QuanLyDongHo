using API_DesignPartern.Entities;

namespace API_DesignPartern.Repositories.DongHoRepositories
{
    public interface IDongHoRepository
    {
        Task<List<DongHo>> GetAllDongHo();
        Task<DongHo> GetDongHoById(Guid id);
        Task CreateDongHo(DongHo dongHo);
        Task UpdateDongHo(DongHo dongHo);
        Task DeleteDongHo(Guid id);
    }
}
