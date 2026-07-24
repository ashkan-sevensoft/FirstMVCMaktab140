using System.ComponentModel.DataAnnotations;

namespace FirstMVCMaktab140.Models
{
    public class LoginDto
    {
        [Required(ErrorMessage = "ایمیل الزامی است")]
        [EmailAddress(ErrorMessage = "ایمیل وارد شده معتبر نمی باشد")]
        [Display(Name = "ایمیل")]
        public string Email { get; set; }


        [Required(ErrorMessage = "رمز عبور الزامی است")]
        [DataType(DataType.Password)]
        [Display(Name = "رمز عبور")]
        public string Password { get; set; }
    }
}
