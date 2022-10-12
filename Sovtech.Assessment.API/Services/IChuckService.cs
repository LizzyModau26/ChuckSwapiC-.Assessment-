using Sovtech.Assessment.Models;

namespace Sovtech.Assessment.Services
{
    public interface IChuckService
    {
        Task<String> GetCategories();
    }
}
