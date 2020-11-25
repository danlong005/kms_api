using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using kms_api.Models;
using Microsoft.EntityFrameworkCore;

namespace kms_api.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class PublishersController : ControllerBase
    {
        private readonly KMSDBContext _context;

        public PublishersController(KMSDBContext context) {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetPublishers()
        {
            return StatusCode(StatusCodes.Status200OK, 
                _context.Publishers.ToList());
        }
    }
}
