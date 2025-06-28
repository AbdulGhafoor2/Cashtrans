using Cashtrans.DataAccessLayer.Interface;
using Cashtrans.DTOS;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cashtrans.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReadLockDataController : ControllerBase
    {
        private readonly IReadLockDataService _lockDataService;

        public ReadLockDataController(IReadLockDataService lockDataService)
        {
            _lockDataService = lockDataService;
        }

        [HttpGet]
        public async Task<IActionResult> ReadLockDataBySerial(string serialNumber)
        {
            if (string.IsNullOrEmpty(serialNumber))
            {
                return BadRequest(new { Message = "Serial number is required." });
            }

            var request = new ReadLockDataRequest
            {
                SerialNumber = serialNumber
            };

            var result = await _lockDataService.ReadLockDataBySerialAsync(request);

            if (!result.IsSuccess)
            {
                return StatusCode(500, result);
            }

            return Ok(result);
        }
    }
}