using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using Resources.Web.StructureMap;

namespace Resources.Web
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            new ResourcesStructureMapConfiguration().Configure();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);

            RegisterRoutes(RouteTable.Routes);
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapRoute("Default", "{controller}/{action}/{id}", new { controller = "SignUp", action = "SignUp", id = UrlParameter.Optional });
        }
    }
}