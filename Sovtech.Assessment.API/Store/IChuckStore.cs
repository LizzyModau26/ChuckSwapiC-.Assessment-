using Sovtech.Assessment.Models;

namespace Sovtech.Assessment.Store
{
    public interface IChuckStore
    {
        Task<String> GetCategories();
    }
}
