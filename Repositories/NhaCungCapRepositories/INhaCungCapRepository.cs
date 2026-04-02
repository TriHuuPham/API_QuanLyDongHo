using API_DesignPartern.Entities;

namespace API_QLDongHo_DesignPartern.Repositories.NhaCungCapRepositories
{
    public interface INhaCungCapRepository
    {
        Task<List<NhaCungCap>> GetAllNhaCungCapsAsync();
        Task<NhaCungCap> GetNhaCungCapByIdAsync(Guid id);
        Task AddNhaCungCapAsync(NhaCungCap nhaCungCap);
        Task UpdateNhaCungCapAsync(NhaCungCap nhaCungCap);
        Task DeleteNhaCungCapAsync(Guid id);
    }
}
