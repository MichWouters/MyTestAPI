using MyMaui.Business.Models;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace MyMaui.Business.Services
{
    public class GameServices : IGameServices
    {
        public async Task<GameModel> GetGame()
        {
            string URL = "https://localhost:7213/Game/GetGame";

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync(URL).Result;

            if (response.IsSuccessStatusCode)
            {
                HttpContent content = response.Content;
                string result = await content.ReadAsStringAsync();

                GameModel gameDTO = JsonConvert.DeserializeObject<GameModel>(result);
                return gameDTO;
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
                return null;
            }
        }
    }
}