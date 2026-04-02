using API_DesignPartern.DTOs.BaseResponse;
using API_DesignPartern.Entities;
using API_DesignPartern.Repositories.DongHoRepositories;

namespace API_DesignPartern.Services.DongHoService
{
    public class DongHoServices : IDongHoServices
    {
        public readonly IDongHoRepository _dongHoRepository;

        public DongHoServices(IDongHoRepository dongHoRepository)
        {
            _dongHoRepository = dongHoRepository;
        }

        public async Task<BaseReponse> GetAllDongHo()
        {
            try
            {
                var GetAllDongHo =  await _dongHoRepository.GetAllDongHo();
                if (GetAllDongHo == null)
                {
                    return new BaseReponse
                    {
                        Code = 404,
                        Message = "Không tìm thấy đồng hồ nào."
                    };
                }

                return new BaseReponse
                {
                    Code = 200,
                    Data = GetAllDongHo,
                    Message = "Lấy danh sách nhà cung cấp thành công."
                };
            }
            catch (Exception ex)
            {
                return new BaseReponse { Code = 500, Message = "Error: " + ex.Message };
            }
        }

        public async Task<BaseReponse> GetDongHoById(Guid id)
        {
            try
            {
                var GetDongHoById = await _dongHoRepository.GetDongHoById(id);
                if (GetDongHoById == null)
                {
                    return new BaseReponse
                    {
                        Code = 404,
                        Message = "Không tìm thấy đồng hồ với ID đã cho."
                    };
                }

                return new BaseReponse
                {
                    Code = 200,
                    Data = GetDongHoById,
                    Message = "Lấy thông tin đồng hồ thành công."
                };
            }
            catch (Exception ex)
            {
                return new BaseReponse { Code = 500, Message = "Error: " + ex.Message };
            }
            
        }


        public async Task<BaseReponse> CreateDongHo(DongHo dongHo)
        {
            try
            {
                await _dongHoRepository.CreateDongHo(dongHo);
                return new BaseReponse { Code = 200, Message = "Tạo đồng hồ thành công." };
            }
            catch (Exception ex)
            {
                return new BaseReponse { Code = 500, Message = "Error: " + ex.Message };
            }
        }

        public async Task<BaseReponse> UpdateDongHo(DongHo dongHo)
        {
            try
            {
                await _dongHoRepository.UpdateDongHo(dongHo);
                return new BaseReponse { Code = 200, Message = "Cập nhật đồng hồ thành công." };
            }
            catch (Exception ex)
            {
                return new BaseReponse { Code = 500, Message = "Error: " + ex.Message };
            }
        }

        public async Task<BaseReponse> DeleteDongHo(Guid id)
        {
            try
            {
                await _dongHoRepository.DeleteDongHo(id);
                return new BaseReponse { Code = 200, Message = "Success" };
            }
            catch (Exception ex)
            {
                return new BaseReponse { Code = 500, Message = "Error: " + ex.Message };
            }
        }
    }
}
