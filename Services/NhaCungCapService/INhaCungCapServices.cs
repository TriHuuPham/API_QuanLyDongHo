using API_DesignPartern.DTOs.BaseResponse;
using API_DesignPartern.Entities;

namespace API_QLDongHo_DesignPartern.Services.NhaCungCapService
{
    public interface INhaCungCapServices
    {
        Task<BaseReponse> GetAllNhaCungCap();
        Task<BaseReponse> GetNhaCungCapById(Guid id);
        Task<BaseReponse> CreateNhaCungCap(NhaCungCap nhaCungCap);
        Task<BaseReponse> UpdateNhaCungCap(NhaCungCap nhaCungCap);
        Task<BaseReponse> DeleteNhaCungCap(Guid id);
    }
}
