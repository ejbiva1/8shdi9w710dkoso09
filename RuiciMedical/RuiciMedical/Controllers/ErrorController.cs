using System.Web;
using System.Web.Mvc;

namespace RuiciMedical.Controllers
{
    public class ErrorController : Controller
    {
        [AllowAnonymous]
        public ActionResult Index(int? httpCode)
        {
            Response.TrySkipIisCustomErrors = true;
            var httpException = RouteData.Values["httpException"] as HttpException;
            httpCode = httpCode ?? (httpException?.GetHttpCode() ?? 500);
            if (Request.IsAjaxRequest())
            {
                Response.StatusCode = httpCode ?? 500;
                var errorInfo = new ErrorInfoViewModel() { ErrorId = RouteData.Values["errorId"].ToString() };
                return this.Json(errorInfo, JsonRequestBehavior.AllowGet);
            }

            switch (httpCode)
            {
                case 401:
                    return View("~/Views/Error/Error401.cshtml");
                case 403:
                    Response.StatusCode = httpCode.Value;
                    return View("~/Views/Error/Error403.cshtml");
                case 404:
                    Response.StatusCode = 404;
                    return View("~/Views/Error/Error404.cshtml");
                case 500:
                default:
                    ViewBag.ErrorId = RouteData.Values["errorId"];
                    Response.StatusCode = 500;
                    return View("~/Views/Error/Error500.cshtml");
            }
        }
        
        public ActionResult Error500()
        {
            return View("~/Views/Error/Error500.cshtml");
        }
        
        public ActionResult Error404()
        {

            return View();
        }
    }
}