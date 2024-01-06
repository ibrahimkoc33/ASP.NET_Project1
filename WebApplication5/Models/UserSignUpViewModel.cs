using System.ComponentModel.DataAnnotations;

namespace WebApplication5.Models
{
    public class UserSignUpViewModel
    {
        [Display(Name="Ad Soyad")]
        [Required(ErrorMessage ="Lütfen Ad soyad giriniz")]
        public string Name { get; set; }

        [Display(Name = "Kullanıcı adı")]
        [Required(ErrorMessage = "Lütfen kullanıcı adı giriniz")]
        public string Username { get; set; }

        [Display(Name = "Mail")]
        [Required(ErrorMessage = "Lütfen mail giriniz")]
        public string Mail { get; set; }

        [Display(Name = "Şifre")]
        
        public string Password { get; set; }

        [Display(Name = "Şifre Tekrar")]
        [Required(ErrorMessage = "Lütfen şifrenizi tekrar giriniz")]
        [Compare("Password",ErrorMessage = "Şifreler Uyuşmuyor")]
        public string ConfirmPassword { get; set; }

    }
}
