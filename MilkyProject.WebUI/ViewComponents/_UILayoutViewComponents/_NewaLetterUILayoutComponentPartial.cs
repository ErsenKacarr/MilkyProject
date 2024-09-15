using Microsoft.AspNetCore.Mvc;
using MilkyProject.WebUI.Dtos.AddressDtos;
using MilkyProject.WebUI.Dtos.NewsletterDtos;
using Newtonsoft.Json;

namespace MilkyProject.WebUI.ViewComponents._UILayoutViewComponents
{
    public class _NewaLetterUILayoutComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public _NewaLetterUILayoutComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7122/api/Newsletter");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultNewsletterDto>>(jsonData);
                return View(values.FirstOrDefault());
            }
            return View();

        }
    }
}
