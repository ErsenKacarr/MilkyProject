using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MilkyProject.BusinessLayer.Abstract;
using MilkyProject.EntityLayer.Concrete;

namespace MilkyProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GalleryController : ControllerBase
    {
        private readonly IGalleryService _galleryService;
        public GalleryController(IGalleryService galleryService)
        {
            _galleryService = galleryService;
        }

        [HttpGet]
        public IActionResult GalleryList()
        {
            var values = _galleryService.TGetListAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult GalleryList(Gallery gallery)
        {
            _galleryService.TInsert(gallery);
            return Ok("Fotoğraf başarıyla eklendi");
        }

        [HttpDelete]
        public IActionResult DeleteGallery(int id)
        {
            _galleryService.TDelete(id);
            return Ok("Fotoğraf başarıyla silindi");
        }

        [HttpPut]
        public IActionResult UpdateGallery(Gallery gallery)
        {
            _galleryService.TUpdate(gallery);
            return Ok("Fotoğraf başarıyla güncellendi");
        }

        [HttpGet("GetGallery")]
        public IActionResult GetGallery(int id)
        {
            var value = _galleryService.TGetById(id);
            return Ok(value);
        }
    }
}
