using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MilkyProject.BusinessLayer.Abstract;
using MilkyProject.EntityLayer.Concrete;

namespace MilkyProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeController : ControllerBase
    {
        private readonly IEmployeService _employeService;
        public EmployeController(IEmployeService employeService)
        {
            _employeService = employeService;
        }

        [HttpGet]
        public IActionResult EmployeList()
        {
            var values = _employeService.TGetListAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult EmployeList(Employe employe)
        {
            _employeService.TInsert(employe);
            return Ok("Çalışan başarıyla eklendi");
        }

        [HttpDelete]
        public IActionResult DeleteEmploye(int id)
        {
            _employeService.TDelete(id);
            return Ok("Çalışan başarıyla silindi");
        }

        [HttpPut]
        public IActionResult UpdateEmploye(Employe employe)
        {
            _employeService.TUpdate(employe);
            return Ok("Çalışan başarıyla güncellendi");
        }

        [HttpGet("GetEmploye")]
        public IActionResult GetEmploye(int id)
        {
            var value = _employeService.TGetById(id);
            return Ok(value);
        }
    }
}
