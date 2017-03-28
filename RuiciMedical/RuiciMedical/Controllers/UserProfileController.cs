using RuiciMedical.Models;
using System.Web.Mvc;

namespace RuiciMedical.Controllers
{
    public class UserProfileController : Controller
    {
        // GET: UserProfile
        public ActionResult Index()
        {
            var model = new UserViewModel
            {
                LoginName = "",
                Name = "",
                NameEn = "",
                Mobile = "",
                Email = "",
                EmployeeNo = "",
                ID = 1,
                NewPassword = "",
                ConfirmPassword = "",
                Photo = ""
            };
            return View(model);
        }
    }
}