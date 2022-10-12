using Sovtech.Assessment.Models;
using Sovtech.Assessment.Store;


namespace Sovtech.Assessment.Services
{
    public class ChuckService : IChuckService
    {

        private readonly IChuckStore _chuckStore;
        public ChuckService(IChuckStore chuckStore)
        {
            _chuckStore = chuckStore;
        }

        public async Task<String> GetCategories()
        {
            return await _chuckStore.GetCategories();
        }
    }
}
