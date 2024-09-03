using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MilkyProject.BusinessLayer.Abstract;
using MilkyProject.EntityLayer.Concrete;

namespace MilkyProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IServiceService _serviceService;
        public ServiceController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        [HttpGet]
        public IActionResult ServiceList()
        {
            var values = _serviceService.TGetListAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult ServiceList(Service service)
        {
            _serviceService.TInsert(service);
            return Ok("Hizmetlerimiz başarıyla eklendi");
        }

        [HttpDelete]
        public IActionResult DeleteService(int id)
        {
            _serviceService.TDelete(id);
            return Ok("Hizmetlerimiz başarıyla silindi");
        }

        [HttpPut]
        public IActionResult UpdateService(Service service)
        {
            _serviceService.TUpdate(service);
            return Ok("Hizmetlerimiz başarıyla güncellendi");
        }

        [HttpGet("GetService")]
        public IActionResult GetService(int id)
        {
            var value = _serviceService.TGetById(id);
            return Ok(value);
        }
    }
}
