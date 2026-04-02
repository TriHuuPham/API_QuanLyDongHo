using API_DesignPartern.DTOs.BaseResponse;
using API_DesignPartern.Entities;

namespace API_QLDongHo_DesignPartern.Services.PhanLoaiService
{
    public interface IPhanLoaiServices
    {
        Task<BaseReponse> GetAllPhanLoai();
        Task<BaseReponse> GetPhanLoaiById(Guid id);
        Task<BaseReponse> CreatePhanLoai(PhanLoai phanLoai);
        Task<BaseReponse> UpdatePhanLoai(PhanLoai phanLoai);
        Task<BaseReponse> DeletePhanLoai(Guid id);
    }
}
