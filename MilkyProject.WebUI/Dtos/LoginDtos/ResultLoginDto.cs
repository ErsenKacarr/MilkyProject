using System.ComponentModel.DataAnnotations;

namespace MilkyProject.WebUI.Dtos.LoginDtos
{
    public class ResultLoginDto
    {
        [Required(ErrorMessage = "Ad Alanı Gereklidir")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Şifre Alanı Gereklidir")]
        public string Password { get; set; }

    }
}
