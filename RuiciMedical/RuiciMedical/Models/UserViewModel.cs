using System.ComponentModel.DataAnnotations;

namespace RuiciMedical.Models
{
    public class UserViewModel
    {
        public int ID { get; set; }

        [System.Web.Mvc.Remote("RemoteValidation", "StaffManagement", AdditionalFields = "type")]
        [Required(ErrorMessage = "用户名不为空")]
        [MaxLength(16, ErrorMessage = "用户名长度在4-16之间")]
        [MinLength(4, ErrorMessage = "用户名长度在4-16之间")]
        [RegularExpression("^[a-zA-z][a-zA-Z0-9_]*$", ErrorMessage = "请输入英文字母开头和数字组合的4-16位用户名")]
        public string LoginName { get; set; }


        [Required(ErrorMessage = "密码不能为空")]
        [MaxLength(16, ErrorMessage = "密码长度在4-16之间")]
        [MinLength(4, ErrorMessage = "密码长度在4-16之间")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "新密码不能为空")]
        [DataType(DataType.Password)]
        public string NewPassword { get; set; }

        [Required(ErrorMessage = "确认密码不能为空")]
        [MaxLength(16, ErrorMessage = "密码长度在4-16之间")]
        [MinLength(4, ErrorMessage = "密码长度在4-16之间")]
        [Compare("NewPassword", ErrorMessage = "新密码和确认密码不一致")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }


        [System.Web.Mvc.Remote("RemoteValidation", "StaffManagement", AdditionalFields = "type")]
        [Required(ErrorMessage = "员工编号不能为空")]
        public string EmployeeNo { get; set; }

        [Required(ErrorMessage = "中文名不能为空")]
        public string Name { get; set; }

        public string NameEn { get; set; }

        public bool Sex { get; set; }

        [RegularExpression(@"(^(\d{3,4}-)?\d{7,8})$|(13[0-9]{9})", ErrorMessage = "电话格式不正确.")]
        public string Phone { get; set; }

        [RegularExpression(@"^(13[0-9]|14[5|7]|15[0|1|2|3|5|6|7|8|9]|18[0|1|2|3|5|6|7|8|9])\d{8}$", ErrorMessage = "手机格式不正确.")]
        public string Mobile { get; set; }

        [RegularExpression(@"^\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "邮箱格式不正确")]
        public string Email { get; set; }

        //public int RoleId { get; set; }

        public string UserGroupId { get; set; }

        public string Remark { get; set; }

        public string DisplayName => !string.IsNullOrEmpty(Name) ? Name : !string.IsNullOrEmpty(NameEn) ? NameEn : LoginName;

        public string Photo { get; set; }

        public bool Inactive { get; set; }

        public string[] SoftPhoneAgents { get; set; }
    }
}
