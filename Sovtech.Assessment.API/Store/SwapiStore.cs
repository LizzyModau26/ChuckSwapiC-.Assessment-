using Sovtech.Assessment.Models;
using System.Net;

namespace Sovtech.Assessment.Store
{
    public class SwapiStore : ISwapiStore
    {
      

       async Task<String> ISwapiStore.GetPeople( string responsetext)
        {
            var url = "https://api.chucknorris.io/jokes/categories";//Paste ur url here  

            WebRequest request = HttpWebRequest.Create(url);

            WebResponse response = request.GetResponse();

            StreamReader reader = new StreamReader(response.GetResponseStream());

            string responseText = reader.ReadToEnd();


            return responseText;
        }
    }
}
