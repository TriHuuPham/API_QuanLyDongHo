using API_DesignPartern.DTOs.BaseResponse;
using API_DesignPartern.Entities;
using API_QLDongHo_DesignPartern.Repositories.ThuongHieuRepositories;

namespace API_QLDongHo_DesignPartern.Services.ThuongHieuService
{
    public class ThuongHieuServices : IThuongHieuServices
    {
        private readonly IThuongHieuRepository _thuongHieuRepository;

        public ThuongHieuServices(IThuongHieuRepository thuongHieuRepository)
        {
            _thuongHieuRepository = thuongHieuRepository;
        }


        public async Task<BaseReponse> GetAllThuongHieu()
        {
            try
            {
                var thuongHieus = await _thuongHieuRepository.GetAllThuongHieusAsync();
                if (thuongHieus == null)
                {
                    return new BaseReponse
                    {
                        Code = 404,
                        Message = "Không tìm thấy thương hiệu nào."
                    };
                }

                return new BaseReponse
                {
                    Code = 200,
                    Data = thuongHieus,
                    Message = "Lấy danh sách thương hiệu thành công."
                };
            }
            catch (Exception ex)
            {
                return new BaseReponse { Code = 500, Message = "Error: " + ex.Message };
            }
        }

        public async Task<BaseReponse> GetThuongHieuById(Guid id)
        {
            try
            {
                var thuongHieu = await _thuongHieuRepository.GetThuongHieuByIdAsync(id);
                if (thuongHieu == null)
                {
                    return new BaseReponse
                    {
                        Code = 404,
                        Message = "Không tìm thấy thương hiệu với ID đã cho."
                    };
                }

                return new BaseReponse
                {
                    Code = 200,
                    Data = thuongHieu,
                    Message = "Lấy thông tin thương hiệu thành công."
                };
            }
            catch (Exception ex)
            {
                return new BaseReponse { Code = 500, Message = "Error: " + ex.Message };
            }
        }

        public async Task<BaseReponse> CreateThuongHieu(ThuongHieu thuongHieu)
        {
            try
            {
                await _thuongHieuRepository.AddThuongHieuAsync(thuongHieu);
                return new BaseReponse
                {
                    Code = 200,
                    Message = "Tạo thương hiệu thành công."
                };
            }
            catch (Exception ex)
            {
                return new BaseReponse { Code = 500, Message = "Error: " + ex.Message };
            }
        }

        public async Task<BaseReponse> UpdateThuongHieu(ThuongHieu thuongHieu)
        {
            try
            {
                await _thuongHieuRepository.UpdateThuongHieuAsync(thuongHieu);
                return new BaseReponse
                {
                    Code = 200,
                    Message = "Cập nhật thương hiệu thành công."
                };
            }
            catch (Exception ex)
            {
                return new BaseReponse { Code = 500, Message = "Error: " + ex.Message };
            }
        }

        public async Task<BaseReponse> DeleteThuongHieu(Guid id)
        {
            try
            {
                await _thuongHieuRepository.DeleteThuongHieuAsync(id);
                return new BaseReponse
                {
                    Code = 200,
                    Message = "Xóa thương hiệu thành công."
                };
            }
            catch (Exception ex)
            {
                return new BaseReponse { Code = 500, Message = "Error: " + ex.Message };
            }
        }
    }
}
