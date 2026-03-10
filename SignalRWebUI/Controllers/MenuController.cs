using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SignalRWebUI.Dtos.BasketDtos;
using SignalRWebUI.Dtos.ProductDtos;
using System.Text;

public class MenuController : Controller
{
    private readonly IHttpClientFactory _httpClientFactory;

    public MenuController(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<IActionResult> Index(int id)
    {
        // 1. ADIM: Masa ID'sini Session'a (hafızaya) alıyoruz.
        if (id != 0)
        {
            HttpContext.Session.SetInt32("menuTableId", id);
        }

        ViewBag.v = id;

        var client = _httpClientFactory.CreateClient();
        var responseMessage = await client.GetAsync("https://localhost:7219/api/Product/ProductListWithCategory");
        var jsonData = await responseMessage.Content.ReadAsStringAsync();
        var values = JsonConvert.DeserializeObject<List<ResultProductDto>>(jsonData);
        return View(values);
    }

    [HttpPost]
    public async Task<IActionResult> AddBasket(int id)
    {
        // 1. Session'dan masa numarasını 'tableId' olarak alıyoruz.
        var tableId = HttpContext.Session.GetInt32("menuTableId");

        if (tableId == null || tableId == 0)
        {
            return BadRequest("Masa seçimi bulunamadı!");
        }

        // 2. Sepete ekleme işlemi
        CreateBasketDto createBasketDto = new CreateBasketDto()
        {
            ProductID = id,
            MenuTableID = (int)tableId
        };

        var client = _httpClientFactory.CreateClient();
        var jsonData = JsonConvert.SerializeObject(createBasketDto);
        StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
        var responseMessage = await client.PostAsync("https://localhost:7219/api/Basket", stringContent);

        // 3. Masa Durumunu Değiştirme (Hata buradaydı: değişken adını 'tableId' yaptık)
        // Eğer metodun ismi ChangeMenuTablesStatusToTrue ise masayı DOLU yapar.
        var client2 = _httpClientFactory.CreateClient();
        await client2.GetAsync("https://localhost:7219/api/MenuTables/ChangeMenuTableStatusToTrue?id=" + tableId);

        if (responseMessage.IsSuccessStatusCode)
        {
            return RedirectToAction("Index", new { id = tableId });
        }

        return Json(createBasketDto);
    }
}