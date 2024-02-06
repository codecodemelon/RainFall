using Microsoft.AspNetCore.Mvc;
using RainFall.Models;
using RainFall.Services;

namespace RainFall.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FloodMonitoringController : ControllerBase
    {
        private readonly FloodMonitoringService _service;

        public FloodMonitoringController(FloodMonitoringService service)
        {
            _service = service;
        }

        [HttpGet("{stationId}")]
        public async Task<ActionResult<BaseModel>> GetMeasureFromStation(string stationId = "3680")
        {
            try
            {
                var result = await _service.GetFloodMonitoringDataAsync(stationId);
                return Ok(result);
            }
            catch (HttpRequestException ex)
            {
                // Handle HTTP request exceptions
                return StatusCode(500, ex.Message);
            }        
        }

        [HttpGet("{stationId}/readings/{limit}")]
        public async Task<ActionResult<BaseModel>> GetReadingFromMeasure(string stationId = "3680", int limit = 20)
        {
            try
            {
                var result = await _service.GetReadingFromMeasureAsync(stationId, limit);
                return Ok(result);
            }
            catch (HttpRequestException ex)
            {
                // Handle HTTP request exceptions
                return StatusCode(500, ex.Message);
            }
        }
    }
}
