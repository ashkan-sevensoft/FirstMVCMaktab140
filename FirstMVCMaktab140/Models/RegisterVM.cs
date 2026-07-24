using System.ComponentModel.DataAnnotations;

namespace FirstMVCMaktab140.Models
{
    public class RegisterVM
    {
        [Required(ErrorMessage = "نام کاربر الزامی است")]
        [Display(Name = "نام کاربر")]
        public  string FullName { get; set; }


        [Required(ErrorMessage = "ایمیل الزامی است")]
        [EmailAddress(ErrorMessage = "ایمیل وارد شده معتبر نمی باشد")]
        [Display(Name = "ایمیل")]
        public string Email { get; set; }


        [Required(ErrorMessage = "رمز عبور الزامی است")]
        [DataType(DataType.Password)]
        [Display(Name = "رمز عبور")]
        public string Password { get; set; }


        [Required(ErrorMessage = "تکرار رمز عبور الزامی است")]
        [DataType(DataType.Password)]
        [Display(Name = "تکرار رمز عبور")]
        [Compare("Password", ErrorMessage = "رمز عبور و تکرار آن یکسان نیستند")]
        public string ConfirmPassword { get; set; }  
    }
}
