using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Service;
using Service.DTOS;
using System;

namespace MapsterTest.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {
        private readonly ILogger<TestController> _logger;
        private readonly ITestService _testService;

        public TestController(ILogger<TestController> logger, ITestService testService)
        {
            _logger = logger;
            _testService = testService;
        }

        [HttpGet]
        public ActionResult<MappedClassDto> GetMappedDTO()
        {
            try
            {
                return Ok(_testService.GetMappedObject());
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An Error Occurred");
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}