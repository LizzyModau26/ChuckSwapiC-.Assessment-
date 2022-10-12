using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Sovtech.Assessment.Models;

namespace Sovtech.Assessment.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("search")]
    [ApiController]
    public class SearchSwapiController : ControllerBase
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly ILogger<SearchSwapiController> _logger;

        /// <summary>
        /// 
        /// </summary>
        private readonly IConfiguration _configuration;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="configuration"></param>
        public SearchSwapiController(ILogger<SearchSwapiController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("people")]
        public IActionResult SearchPeople(string query)
        {
            var url = $"{_configuration["SearchSwapi"]}";
            var httpWebRequest = WebRequest.Create( url + query) as HttpWebRequest;


            httpWebRequest.Method = WebRequestMethods.Http.Get;
            httpWebRequest.Headers.Add("Accept-Language", "en-US");
            httpWebRequest.Headers.Add(HttpRequestHeader.AcceptEncoding, "gzip,deflate");

            using (var httpWebResponse = httpWebRequest.GetResponse() as HttpWebResponse)
            {
                Stream stream = null;
                using (stream = httpWebResponse.GetResponseStream())
                {
                    if (httpWebResponse.ContentEncoding.ToLower().Contains("gzip"))
                        stream = new GZipStream(stream, CompressionMode.Decompress);
                    else if (httpWebResponse.ContentEncoding.ToLower().Contains("deflate"))
                        stream = new DeflateStream(stream, CompressionMode.Decompress);

                    var streamReader = new StreamReader(stream, Encoding.UTF8);
                    string? response = streamReader.ReadToEnd();

                    return Ok(response);
                }

            }
        }
    }
}
