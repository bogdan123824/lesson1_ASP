using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("getdate")]
    public class GetDate : ControllerBase
    {
        private readonly ILogger<GetDate> _logger;

        public GetDate(ILogger<GetDate> logger)
        {
            _logger = logger;
        }

        [HttpGet( Name = "CalculateGetDate")]
        public ActionResult<int> GetDateDifference(string date)
        {
            if (DateTime.TryParse(date, out DateTime parsedDate))
            {
                var currentDate = DateTime.Now;
                var difference = (currentDate - parsedDate).Days;
                return (difference);
            }
            else
            {
                return BadRequest("Please enter correct date");
            }
        }

        [HttpGet("calculateAverage", Name = "GetAverage")]
        public ActionResult<double> GetAverage([FromQuery] List<int> numbers)
        {
            double average = numbers.Average();
            return (average);
        }

        
    }
}
