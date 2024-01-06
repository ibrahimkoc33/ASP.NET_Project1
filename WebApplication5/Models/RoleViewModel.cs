using System.ComponentModel.DataAnnotations;

namespace WebApplication5.Models
{
    public class RoleViewModel
    {
        [Required(ErrorMessage ="Lütfen Rol Adı giriniz")]
        public string name { get; set; }
    }
}
