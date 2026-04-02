using API_DesignPartern.DTOs.BaseResponse;
using API_DesignPartern.Entities;
using API_QLDongHo_DesignPartern.Repositories.NhaCungCapRepositories;

namespace API_QLDongHo_DesignPartern.Services.NhaCungCapService
{
    public class NhaCungCapServices : INhaCungCapServices
    {
        public readonly INhaCungCapRepository _nhaCungCapRepository;

        public NhaCungCapServices(INhaCungCapRepository nhaCungCapRepository)
        {
            _nhaCungCapRepository = nhaCungCapRepository;
        }

        public async Task<BaseReponse> GetAllNhaCungCap()
        {
            try
            {
                var nhaCungCaps = await _nhaCungCapRepository.GetAllNhaCungCapsAsync();
                if (nhaCungCaps == null)
                {
                    return new BaseReponse
                    {
                        Code = 404,
                        Message = "Không tìm thấy nhà cung cấp nào."
                    };
                }

                return new BaseReponse
                {
                    Code = 200,
                    Data = nhaCungCaps,
                    Message = "Lấy danh sách nhà cung cấp thành công."
                };
            }
            catch (Exception ex)
            {
                return new BaseReponse { Code = 500, Message = "Error: " + ex.Message };
            }
        }

        public async Task<BaseReponse> GetNhaCungCapById(Guid id)
        {
            try
            {
                var nhaCungCap = await _nhaCungCapRepository.GetNhaCungCapByIdAsync(id);
                if (nhaCungCap == null)
                {
                    return new BaseReponse
                    {
                        Code = 404,
                        Message = "Không tìm thấy nhà cung cấp với ID đã cho."
                    };
                }

                return new BaseReponse
                {
                    Code = 200,
                    Data = nhaCungCap,
                    Message = "Lấy thông tin nhà cung cấp thành công."
                };
            }
            catch (Exception ex)
            {
                return new BaseReponse { Code = 500, Message = "Error: " + ex.Message };
            }
        }

        public async Task<BaseReponse> CreateNhaCungCap(NhaCungCap nhaCungCap)
        {
            try
            {
                await _nhaCungCapRepository.AddNhaCungCapAsync(nhaCungCap);
                return new BaseReponse
                {
                    Code = 200,
                    Message = "Tạo nhà cung cấp thành công."
                };
            }
            catch (Exception ex)
            {
                return new BaseReponse { Code = 500, Message = "Error: " + ex.Message };
            }
        }

        public async Task<BaseReponse> UpdateNhaCungCap(NhaCungCap nhaCungCap)
        {
            try
            {
                await _nhaCungCapRepository.UpdateNhaCungCapAsync(nhaCungCap);
                return new BaseReponse
                {
                    Code = 200,
                    Message = "Cập nhật nhà cung cấp thành công."
                };
            }
            catch (Exception ex)
            {
                return new BaseReponse { Code = 500, Message = "Error: " + ex.Message };
            }
        }

        public async Task<BaseReponse> DeleteNhaCungCap(Guid id)
        {
            try
            {
                await _nhaCungCapRepository.DeleteNhaCungCapAsync(id);
                return new BaseReponse
                {
                    Code = 200,
                    Message = "Xóa nhà cung cấp thành công."
                };
            }
            catch (Exception ex)
            {
                return new BaseReponse { Code = 500, Message = "Error: " + ex.Message };
            }
        }
    }
}
