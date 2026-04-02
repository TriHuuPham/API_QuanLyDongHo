using API_DesignPartern.DTOs.BaseResponse;
using API_DesignPartern.Entities;

namespace API_DesignPartern.Services.DongHoService
{
    public interface IDongHoServices
    {
        Task<BaseReponse> GetAllDongHo();
        Task<BaseReponse> GetDongHoById(Guid id);
        Task<BaseReponse> CreateDongHo(DongHo dongHo);
        Task<BaseReponse> UpdateDongHo(DongHo dongHo);
        Task<BaseReponse> DeleteDongHo(Guid id);
    }
}
