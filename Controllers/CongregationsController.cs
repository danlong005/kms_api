using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using kms_api.Services;

namespace kms_api.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class CongregationsController : ControllerBase 
    {
        private readonly ICongregationService _service;

        public CongregationsController(ICongregationService service) {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetCongregations()
        {
            return StatusCode(StatusCodes.Status200OK, _service.GetCongregations());
        }

        [HttpGet("{id}/meetings")]
        public IActionResult GetCongregationMeetings(int id)
        {
            return StatusCode(StatusCodes.Status200OK, _service.GetCongregationMeetings(id));
        }
    }
}
