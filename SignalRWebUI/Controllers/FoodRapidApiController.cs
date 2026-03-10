using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SignalRWebUI.Dtos.RapidApiDtos;

namespace SignalRWebUI.Controllers
{
    public class FoodRapidApiController : Controller
    {
        public async Task<IActionResult> Index()
        {
          
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("*****"),
                Headers =
    {
        { "x-rapidapi-key", "*****" },
        { "x-rapidapi-host", "tasty.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                //resultTastyApis = JsonConvert.DeserializeObject<List<ResultTastyApi>>(body);
                //return View(resultTastyApis);
                var root = JsonConvert.DeserializeObject<RootTastyApi>(body);
                var values = root.Results;
                return View(values.ToList());
            }

         
        }
    }
}
