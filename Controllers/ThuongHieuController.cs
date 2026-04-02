using API_DesignPartern.Entities;
using API_QLDongHo_DesignPartern.Services.ThuongHieuService;
using Microsoft.AspNetCore.Mvc;

namespace API_QLDongHo_DesignPartern.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ThuongHieuController : ControllerBase
    {
        private readonly IThuongHieuServices _thuongHieuServices;
        public ThuongHieuController(IThuongHieuServices thuongHieuServices)
        {
            _thuongHieuServices = thuongHieuServices;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllThuongHieu()
        {
            var result = await _thuongHieuServices.GetAllThuongHieu();
            return Ok(result);
        }

         [HttpGet("{id}")]
         public async Task<IActionResult> GetThuongHieuById(Guid id)
         {
            var result = await _thuongHieuServices.GetThuongHieuById(id);
            return Ok(result);
         }

        [HttpPost]
        public async Task<IActionResult> CreateThuongHieu(ThuongHieu thuongHieu)
        {
            var result = await _thuongHieuServices.CreateThuongHieu(thuongHieu);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateThuongHieu(ThuongHieu thuongHieu)
        {
            var result = await _thuongHieuServices.UpdateThuongHieu(thuongHieu);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteThuongHieu(Guid id)
        {
            var result = await _thuongHieuServices.DeleteThuongHieu(id);
            return Ok(result);
        }
    }
}
