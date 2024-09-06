using Microsoft.AspNetCore.Mvc;
using MilkyProject.WebUI.Dtos;
using MilkyProject.WebUI.Dtos.CategoryDtos;
using MilkyProject.WebUI.Dtos.EmployeDtos;
using Newtonsoft.Json;
using System.Text;

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
        [HttpGet]
        public IActionResult CreateEmploye()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateEmploye(CreateEmployeDto createEmployeDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createEmployeDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("https://localhost:7122/api/Employe", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
