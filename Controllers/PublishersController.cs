using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using kms_api.Services;
using kms_api.Models;

namespace kms_api.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class PublishersController : ControllerBase
    {
        private readonly IPublisherService _publisherService;

        public PublishersController(IPublisherService publisherService) {
            _publisherService = publisherService;
        }

        [HttpGet]
        public IActionResult GetPublishers()
        {
            return StatusCode(StatusCodes.Status200OK, 
                _publisherService.GetPublishers());
        }

        [HttpPost]
        public IActionResult CreatePublisher(Publisher publisher)
        {
            return StatusCode(StatusCodes.Status201Created, 
                _publisherService.CreatePublisher(publisher));
        }
    }
}
