using Sovtech.Assessment.Models;

namespace Sovtech.Assessment.Services
{
    public interface ISwapiService
    {
       Task<String> GetPeople(string responsetext);
    }
}
