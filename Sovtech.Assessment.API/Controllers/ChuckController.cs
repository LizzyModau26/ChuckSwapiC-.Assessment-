using Sovtech.Assessment.Models;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Newtonsoft.Json;
using Microsoft.Extensions.Configuration;

namespace Sovtech.Assessment.Controllers
{

    /// <summary>
    ///       This class contains the API action request response methods.
    /// </summary>
    [ApiController]
    [Route("categories")]
    public class ChuckController : ControllerBase
    {
        /// <summary>
        ///     Creating an instance of _logger for <see cref="ILogger"/> interface.
        /// </summary>
        private readonly ILogger<ChuckController> _logger;
        /// <summary>
        ///     Creating an instance of _configuration for <see cref="IConfiguration"/> interface.
        /// </summary>
        private readonly IConfiguration _configuration;

        /// <summary>
        ///      Initialises a new instance of the <see cref="ChuckController"/> class.
        /// </summary>
        /// <param name="logger"> Creating an instance of _logger for <see cref="ILogger"/> interface.</param>
        /// <param name="configuration">Creating an instance of _configuration for <see cref="IConfiguration"/> interface.</param>
        public ChuckController(ILogger<ChuckController> logger, IConfiguration configuration)
    {
        _logger = logger;
        _configuration = configuration;
    }

    /// <summary>
    ///     Retrieves Chuck Norris API jokes categories successfully.
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
