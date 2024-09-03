using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MilkyProject.BusinessLayer.Abstract;
using MilkyProject.EntityLayer.Concrete;

namespace MilkyProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly IAddressService _addressService;

        public AddressController(IAddressService addressService)
        {
            _addressService = addressService;
        }

        [HttpGet]
        public IActionResult AddressList()
        {
            var values = _addressService.TGetListAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddressList(Address address)
        {
            _addressService.TInsert(address);
            return Ok("Adres başarıyla eklendi");
        }

        [HttpDelete]
        public IActionResult DeleteAddress(int id)
        {
            _addressService.TDelete(id);
            return Ok("Adres başarıyla silindi");
        }

        [HttpPut]
        public IActionResult UpdateAddress(Address address)
        {
            _addressService.TUpdate(address);
            return Ok("Adres başarıyla güncellendi");
        }

        [HttpGet("GetAddress")]
        public IActionResult GetAddress(int id)
        {
            var value = _addressService.TGetById(id);
            return Ok(value);
        }
    }
}
