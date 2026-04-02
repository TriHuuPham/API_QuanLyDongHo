using API_DesignPartern.Entities;
using API_DesignPartern.Services.DongHoService;
using Microsoft.AspNetCore.Mvc;

namespace API_DesignPartern.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DongHoController : ControllerBase
    {
        public readonly IDongHoServices _dongHoService;

        public DongHoController(IDongHoServices dongHoService)
        {
            _dongHoService = dongHoService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllDongHo()
        {
            var result = await _dongHoService.GetAllDongHo();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDongHoById(Guid id)
        {
            var result = await _dongHoService.GetDongHoById(id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateDongHo(DongHo dongHo)
        {
            var result = await _dongHoService.CreateDongHo(dongHo);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateDongHo(DongHo dongHo)
        {
            var result = await _dongHoService.UpdateDongHo(dongHo);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDongHo(Guid id)
        {
            var result = await _dongHoService.DeleteDongHo(id);
            return Ok(result);
        }
    }
}
