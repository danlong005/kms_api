using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Linq;
using kms_api.Models;
using Microsoft.EntityFrameworkCore;

namespace kms_api.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class MeetingsController : ControllerBase
    {
        private readonly KMSDBContext _context;

        public MeetingsController(KMSDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetMeetings()
        {
            return StatusCode(StatusCodes.Status200OK, 
                _context.Meetings.
                Include(m => m.Parts).ThenInclude(p => p.Publisher).
                Include(m => m.Parts).ThenInclude(p => p.Assistant).
                ToList());
        }
    }
}
