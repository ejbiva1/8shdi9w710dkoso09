using System.Web.Mvc;

namespace RuiciMedical.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Account/Login
        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        //
        // GET: /Account/Register
        [AllowAnonymous]
        public ActionResult Register()
        {
            return View();
        }

        public class UserParam
        {
            public string UserID { get; set; }
            public string UserCode { get; set; }
            public string ReturnUrl { get; set; }
        }

        [AllowAnonymous]
        public ActionResult LoginSuccess(UserParam param)
        {
            //TODO ValidateLoginUser
            //if (ValidateLoginUser(param.UserCode))
            //{
            //    //.SignIn(param.UserCode, false);
            //    return RedirectToLocal(param.ReturnUrl);
            //}
            return Redirect("/");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LogOff()
        {
            //SignOut;
            return Redirect("SignOut?returnUrl=");
        }

        private ActionResult RedirectToLocal(string returnUrl)
        {
            if (!string.IsNullOrEmpty(returnUrl))
            {
                return Redirect(returnUrl);
            }
            return Redirect("/");
        }
    }
}