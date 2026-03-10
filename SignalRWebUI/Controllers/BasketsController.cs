using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SignalRWebUI.Dtos.BasketDtos;
using System.Text;

namespace SignalRWebUI.Controllers
{
    public class BasketsController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public BasketsController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            // 1. Session'dan hangi masada olduğumuzu alıyoruz
            var tableId = HttpContext.Session.GetInt32("menuTableId");

            // Eğer session boşsa (direkt linkle gelindiyse) masa seçimine geri gönder
            if (tableId == null || tableId == 0)
            {
                return RedirectToAction("Index", "Menu");
            }

            var client = _httpClientFactory.CreateClient();

            // 2. API'ye giderken ?id= sorgusuyla masa numarasını ekliyoruz
            // API tarafındaki metodun ismi ve beklediği parametre (id) burada çok önemli
            var responseMessage = await client.GetAsync($"https://localhost:7219/api/Basket/BasketListByMenuTableWithProductName?id={tableId}");

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultBasketDto>>(jsonData);

                // Masa numarasını sayfada başlıkta göstermek istersen ViewBag'e atalım
                ViewBag.TableId = tableId;

                return View(values);
            }
            return View();
        }

        public async Task<IActionResult> DeleteBasket(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"https://localhost:7219/api/Basket/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return NoContent();
        }
    }
}
