using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("time")]
    public class RecordTime : ControllerBase
    {
        private readonly ILogger<RecordTime> _logger;

        public RecordTime(ILogger<RecordTime> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetCurrentTime")]
        public ActionResult<string> GetCurrentTime()
        {
            var currentTime = DateTime.Now.ToString("HH:mm:ss");
            return (currentTime);
        }
    }
}

