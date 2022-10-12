using Sovtech.Assessment.Models;

namespace Sovtech.Assessment.Store
{
    public class ChuckStore : IChuckStore
    {
        public async Task<String>GetCategories()
        {
            string page = "https://api.chucknorris.io/jokes/categories";

            // ... Use HttpClient.
            using (HttpClient client = new HttpClient())
            using (HttpResponseMessage response = await client.GetAsync(page))
            using (HttpContent content = response.Content) {

                // ... Read the string.
                string result = await content.ReadAsStringAsync();
                return result;
                    }
        }
    }
}
