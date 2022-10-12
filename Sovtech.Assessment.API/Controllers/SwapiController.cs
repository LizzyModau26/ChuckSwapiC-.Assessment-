
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Sovtech.Assessment.Models;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;

namespace Sovtech.Assessment.Controllers
{

        /// <summary>
        /// 
        /// </summary>
        [ApiController]
        [Route("swapi/people")]
        public class SwapiController : ControllerBase
        {
        /// <summary>
        /// 
        /// </summary>
        private readonly ILogger<SwapiController> _logger;

        /// <summary>
        /// 
        /// </summary>
        private readonly IConfiguration _configuration;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="configuration"></param>
        public SwapiController(ILogger<SwapiController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [SwaggerOperation("get-all-actors")]
        [SwaggerResponse(200, description: "Successfully retrieved all Star Wars Actors")]
        public IActionResult GetPeople()
        {
            var url = $"{_configuration["SwapiURL"]}";
                    var client = GetAsync(url).GetAwaiter().GetResult();
                    return Ok(client);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="uri"></param>
        /// <returns></returns>
        public static async Task<string> GetAsync(string uri)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(uri);

            string content = await response.Content.ReadAsStringAsync();
            return await Task.Run(() => (content));
        }
        }
}
