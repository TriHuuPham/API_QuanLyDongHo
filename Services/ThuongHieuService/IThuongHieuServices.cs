using API_DesignPartern.DTOs.BaseResponse;
using API_DesignPartern.Entities;

namespace API_QLDongHo_DesignPartern.Services.ThuongHieuService
{
    public interface IThuongHieuServices
    {
        Task<BaseReponse> GetAllThuongHieu();
        Task<BaseReponse> GetThuongHieuById(Guid id);
        Task<BaseReponse> CreateThuongHieu(ThuongHieu thuongHieu);
        Task<BaseReponse> UpdateThuongHieu(ThuongHieu thuongHieu);
        Task<BaseReponse> DeleteThuongHieu(Guid id);
    }
}
