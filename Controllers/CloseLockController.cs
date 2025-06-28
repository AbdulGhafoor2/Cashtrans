using Cashtrans.DataAccessLayer.Interface;
using Cashtrans.DTOS;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace Cashtrans.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CloseLockController : ControllerBase
    {
        private readonly ICloseLockService _lockService;

        public CloseLockController(ICloseLockService lockService)
        {
            _lockService = lockService;
        }

        [HttpPost]
        public async Task<IActionResult> CloseLock([FromBody] CloseLockRequest requestDto)
        {
            try
            {
                var result = await _lockService.CloseLockBySerialAsync(requestDto);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
    }
}
