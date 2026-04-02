using API_DesignPartern.Entities;
using API_QLDongHo_DesignPartern.Services.NhaCungCapService;
using Microsoft.AspNetCore.Mvc;

namespace API_QLDongHo_DesignPartern.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NhaCungCapController : ControllerBase
    {
        public readonly INhaCungCapServices _nhaCungCapServices;

        public NhaCungCapController(INhaCungCapServices nhaCungCapServices)
        {
            _nhaCungCapServices = nhaCungCapServices;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllNhaCungCap()
        {
            // Logic to get all NhaCungCap
            var result = await _nhaCungCapServices.GetAllNhaCungCap();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetNhaCungCapById(Guid id)
        {
            var result = await _nhaCungCapServices.GetNhaCungCapById(id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateNhaCungCap(NhaCungCap nhaCungCap)
        {
            var result = await _nhaCungCapServices.CreateNhaCungCap(nhaCungCap);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateNhaCungCap(NhaCungCap nhaCungCap)
        {
            var result = await _nhaCungCapServices.UpdateNhaCungCap(nhaCungCap);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNhaCungCap(Guid id)
        {
            var result = await _nhaCungCapServices.DeleteNhaCungCap(id);
            return Ok(result);
        }
    }
}
