using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using kms_api.Services;
using kms_api.Models;

namespace kms_api.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class MeetingsController : ControllerBase
    {
        private readonly IMeetingService _meetingService;

        public MeetingsController(IMeetingService meetingService)
        {
            _meetingService = meetingService;
        }

        [HttpGet]
        public IActionResult GetMeetings()
        {
            return StatusCode(StatusCodes.Status200OK, _meetingService.GetMeetings());
        }

        [HttpPost]
        public IActionResult CreateMeeting(Meeting meeting)
        {
            return StatusCode(StatusCodes.Status201Created, _meetingService.CreateMeeting(meeting));
        }
    }
}
