using System.Linq;
using Microsoft.AspNetCore.Mvc;
using kms_api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace kms_api.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class CongregationsController : ControllerBase 
    {
        private readonly KMSDBContext _context;

        public CongregationsController(KMSDBContext context) {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetCongregations()
        {
            return StatusCode(StatusCodes.Status200OK, 
                _context.Congregations.Include(c => c.Publishers).ToList());
        }

        [HttpGet("{id}/meetings")]
        public IActionResult GetCongregationMeeting(int id)
        {
            return StatusCode(StatusCodes.Status200OK, 
                _context.Congregations.Where(c => c.CongregationID == id).
                Include(c => c.Meetings).ThenInclude(m => m.Parts).ThenInclude(p => p.Publisher).
                Include(c => c.Meetings).ThenInclude(m => m.Parts).ThenInclude(p => p.Assistant).ToList());
        }
    }
}
