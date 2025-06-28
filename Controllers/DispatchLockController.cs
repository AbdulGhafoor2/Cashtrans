using Cashtrans.DataAccessLayer.Interface;
using Cashtrans.DTOS;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cashtrans.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DispatchLockController : ControllerBase
    {
        private readonly IDispatchLockService _service;

        public DispatchLockController(IDispatchLockService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> DispatchLock([FromBody] DispatchLockRequest request)
        {
            try
            {
                var result = await _service.DispatchLockAsync(request);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { error = ex.Message });
            }
        }
    }
}

