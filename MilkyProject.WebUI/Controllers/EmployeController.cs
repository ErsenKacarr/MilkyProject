using Microsoft.AspNetCore.Mvc;
using MilkyProject.WebUI.Dtos;
using MilkyProject.WebUI.Dtos.EmployeDtos;
using Newtonsoft.Json;

namespace MilkyProject.WebUI.Controllers
{
    public class EmployeController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public EmployeController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7122/api/Employe");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResulEmployeDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
