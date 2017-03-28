using System.ComponentModel.DataAnnotations;

namespace RuiciMedical.Models
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "账        号")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "密        码")]
        public string Password { get; set; }

        [Display(Name = "自动登录")]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "手  机  号")]
        public string CellPhoneNumber { get; set; }

        [Required]
        [Display(Name = "验  证  码")]
        public string ValidationCode { get; set; }

        [Required]
        [Display(Name = "姓      名")]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "性      别")]
        public string gender { get; set; }

        [Required]
        [Display(Name = "身份证号")]
        public string IDNumber { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "设置密码")]
        public string Password { get; set; }

        [Required]
        [Display(Name = "我同意")]
        public bool ConfirmAgreement { get; set; }
    }
}