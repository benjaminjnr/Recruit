using System.Web.Mvc;
using System.Web.Routing;

namespace Recruit
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Home",
                url: "",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Jobs Search",
                url: "jobs/search",
                defaults: new { controller = "Job", action = "Search" }
            );

            routes.MapRoute(
                name: "Employer",
                url: "employer",
                defaults: new { controller = "Employer", action = "Index"}
            );

            routes.MapRoute(
                name: "User Registration",
                url: "applicant/register",
                defaults: new { controller = "Applicant", action="Index" }
            );

            routes.MapRoute(
                name: "Sign In",
                url: "signin",
                defaults: new { controller = "Auth", action="Index" }
            );


        }
    }
}
