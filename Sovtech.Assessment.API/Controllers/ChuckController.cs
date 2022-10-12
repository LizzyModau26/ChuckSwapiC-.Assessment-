using Sovtech.Assessment.Models;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Newtonsoft.Json;
using Microsoft.Extensions.Configuration;

namespace Sovtech.Assessment.Controllers
{

    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("categories")]
    public class ChuckController : ControllerBase
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly ILogger<ChuckController> _logger;
        /// <summary>
        /// 
        /// </summary>
    private readonly IConfiguration _configuration;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="configuration"></param>
    public ChuckController(ILogger<ChuckController> logger, IConfiguration configuration)
    {
        _logger = logger;
        _configuration = configuration;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    [HttpGet]
        [SwaggerOperation("get-all-categories")]
        [SwaggerResponse(200, description: "Successfully retrieved all categories")]
        public IActionResult GetCategories()
        {
            

            var url = $"{_configuration["ChuckURL"]}/categories";
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
