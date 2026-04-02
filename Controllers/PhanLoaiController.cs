using API_DesignPartern.Entities;
using API_QLDongHo_DesignPartern.Services.PhanLoaiService;
using Microsoft.AspNetCore.Mvc;

namespace API_QLDongHo_DesignPartern.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PhanLoaiController : ControllerBase
    {
        private readonly IPhanLoaiServices _phanLoaiServices;

        public PhanLoaiController(IPhanLoaiServices phanLoaiServices)
        {
            _phanLoaiServices = phanLoaiServices;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllPhanLoai()
        {
            var result = await _phanLoaiServices.GetAllPhanLoai();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPhanLoaiById(Guid id)
        {
            var result = await _phanLoaiServices.GetPhanLoaiById(id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreatePhanLoai(PhanLoai phanLoai)
        {
            var result = await _phanLoaiServices.CreatePhanLoai(phanLoai);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> UpdatePhanLoai(PhanLoai phanLoai)
        {
            var result = await _phanLoaiServices.UpdatePhanLoai(phanLoai);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePhanLoai(Guid id)
        {
            var result = await _phanLoaiServices.DeletePhanLoai(id);
            return Ok(result);
        }
    }
}
