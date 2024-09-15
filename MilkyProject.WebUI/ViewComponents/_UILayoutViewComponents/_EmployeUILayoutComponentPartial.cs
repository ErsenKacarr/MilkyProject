using Microsoft.AspNetCore.Mvc;
using MilkyProject.WebUI.Dtos.AboutDtos;
using MilkyProject.WebUI.Dtos.EmployeDtos;
using Newtonsoft.Json;

namespace MilkyProject.WebUI.ViewComponents._UILayoutViewComponents
{
    public class _EmployeUILayoutComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public _EmployeUILayoutComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7122/api/Employe");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultEmployeDto>>(jsonData);
                return View(values);
            }
            return View();

        }
    }
}
