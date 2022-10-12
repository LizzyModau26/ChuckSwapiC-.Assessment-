using Sovtech.Assessment.Models;
using Sovtech.Assessment.Store;

namespace Sovtech.Assessment.Services
{
    public class SwapiService : ISwapiService
    {
        private readonly ISwapiStore _swapiStore;
        public SwapiService(ISwapiStore swapiStore)
        {
            _swapiStore = swapiStore;
        }
        public async Task<String> GetPeople(string responsetext)
        {
            return await _swapiStore.GetPeople(responsetext);
        }
    }
}
