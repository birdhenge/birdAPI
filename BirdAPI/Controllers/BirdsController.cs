using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.Xml;

namespace BirdAPI.Controllers
{



    /// <summary>
     /// 
     /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class BirdsController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<BirdsController> _logger;

        public BirdsController(ILogger<BirdsController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// By passing in the appropriate options, you can search for
        /// birds present in the system
        /// </summary>
        /// <param name="id"></param>
        /// <response code="200">search results matching criteria</response>
        /// <response code="400">bad input parameter</response>
        [HttpGet]
        [Route("birds")]
        [ProducesResponseType(statusCode: 200, type: typeof(List<BirdSpecies>))]
        [ProducesResponseType(statusCode: 400)]
        public IActionResult GetBirds(int id)
        {
            var bird = new BirdSpecies
            {
                Name = "Barn Own",
                Id = id,
                ValidUntilDate = DateTime.Now,
            };
            return Ok(new List<BirdSpecies>(new[] { bird }));
        }
    }
}