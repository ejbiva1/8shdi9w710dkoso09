using RuiciMedical.Controllers;
using RuiciMedical.Utilities;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace RuiciMedical
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }

        protected void Application_Error()
        {
            HttpContextBase currentContext = new HttpContextWrapper(HttpContext.Current);
            UrlHelper urlHelper = new UrlHelper(HttpContext.Current.Request.RequestContext);
            RouteData routeData = urlHelper.RouteCollection.GetRouteData(currentContext);
            string action = routeData.Values["action"] == null ? "" : routeData.Values["action"] as string;
            string controller = routeData.Values["controller"] == null ? "" : routeData.Values["controller"] as string;

            var exception = Server.GetLastError();

            var httpException = new HttpException(null, exception);
            if (httpException.GetHttpCode() == 404 && WebHelper.IsStaticResource(this.Request))
            {
                return;
            }

            var errorId = "";
            //TODO: 记录Log（忽略404，403） 
            var errorrouteData = new RouteData();
            errorrouteData.Values.Add("controller", "Error");
            errorrouteData.Values.Add("action", "Index");
            errorrouteData.Values.Add("errorId", errorId);
            errorrouteData.Values.Add("httpException", httpException);
            Server.ClearError();

            //TODO: 跳转到错误页面
            IController errorController = DependencyResolver.Current.GetService<ErrorController>();
            errorController.Execute(new RequestContext(new HttpContextWrapper(Context), errorrouteData));




        }
    }
}
