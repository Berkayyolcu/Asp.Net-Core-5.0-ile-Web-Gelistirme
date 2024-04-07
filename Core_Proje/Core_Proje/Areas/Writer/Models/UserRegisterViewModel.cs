using System.ComponentModel.DataAnnotations;

namespace Core_Proje.Areas.Writer.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen  Adını Girin")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen Soyadınızı Girin")]
        public string Surname { get; set; }

        //[Required(ErrorMessage = "Lütfen Resim Seciniz")]
        public string ImageUrl { get; set; }

        [Required(ErrorMessage ="Lütfen Kullanıcı Adını Girin")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen Sifrenizi Adını Girin")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lütfen Sifrenzi Tekrar Girin")]
        [Compare("Password",ErrorMessage ="Sifreler Uyumlu Değil !")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Lütfen Mail Girin")]
        public string Mail { get; set; }
    }
}
