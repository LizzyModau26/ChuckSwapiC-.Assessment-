using Sovtech.Assessment.Models;

namespace Sovtech.Assessment.Store
{
    public interface ISwapiStore
    {
         Task<String> GetPeople(string responsetext);
    }
}
