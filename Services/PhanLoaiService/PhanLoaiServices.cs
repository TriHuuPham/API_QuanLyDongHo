using API_DesignPartern.DTOs.BaseResponse;
using API_DesignPartern.Entities;
using API_QLDongHo_DesignPartern.Repositories.PhanLoaiRepositories;

namespace API_QLDongHo_DesignPartern.Services.PhanLoaiService
{
    public class PhanLoaiServices : IPhanLoaiServices
    {
        private readonly IPhanLoaiRepository _phanLoaiRepository;

        public PhanLoaiServices(IPhanLoaiRepository phanLoaiRepository)
        {
            _phanLoaiRepository = phanLoaiRepository;
        }

        public async Task<BaseReponse> GetAllPhanLoai()
        {
            try
            {
                var phanLoais = await _phanLoaiRepository.GetAllPhanLoaisAsync();
                if (phanLoais == null)
                {
                    return new BaseReponse
                    {
                        Code = 404,
                        Message = "Không tìm thấy phân loại nào."
                    };
                }

                return new BaseReponse
                {
                    Code = 200,
                    Data = phanLoais,
                    Message = "Lấy danh sách phân loại thành công."
                };
            }
            catch (Exception ex)
            {
                return new BaseReponse { Code = 500, Message = "Error: " + ex.Message };
            }
        }

        public async Task<BaseReponse> GetPhanLoaiById(Guid id)
        {
            try
            {
                var phanLoai = await _phanLoaiRepository.GetPhanLoaiByIdAsync(id);
                if (phanLoai == null)
                {
                    return new BaseReponse
                    {
                        Code = 404,
                        Message = "Không tìm thấy phân loại với ID đã cho."
                    };
                }

                return new BaseReponse
                {
                    Code = 200,
                    Data = phanLoai,
                    Message = "Lấy thông tin phân loại thành công."
                };
            }
            catch (Exception ex)
            {
                return new BaseReponse { Code = 500, Message = "Error: " + ex.Message };
            }
        }

        public async Task<BaseReponse> CreatePhanLoai(PhanLoai phanLoai)
        {
            try
            {
                await _phanLoaiRepository.AddPhanLoaiAsync(phanLoai);
                return new BaseReponse
                {
                    Code = 200,
                    Message = "Tạo phân loại thành công."
                };
            }
            catch (Exception ex)
            {
                return new BaseReponse { Code = 500, Message = "Error: " + ex.Message };
            }
        }

        public async Task<BaseReponse> UpdatePhanLoai(PhanLoai phanLoai)
        {
            try
            {
                await _phanLoaiRepository.UpdatePhanLoaiAsync(phanLoai);
                return new BaseReponse
                {
                    Code = 200,
                    Message = "Cập nhật phân loại thành công."
                };
            }
            catch (Exception ex)
            {
                return new BaseReponse { Code = 500, Message = "Error: " + ex.Message };
            }
        }

        public async Task<BaseReponse> DeletePhanLoai(Guid id)
        {
            try
            {
                await _phanLoaiRepository.DeletePhanLoaiAsync(id);
                return new BaseReponse
                {
                    Code = 200,
                    Message = "Xóa phân loại thành công."
                };
            }
            catch (Exception ex)
            {
                return new BaseReponse { Code = 500, Message = "Error: " + ex.Message };
            }
        }
    }
}
