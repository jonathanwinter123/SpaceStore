namespace SpaceStorium
{
    using System.Web.Mvc;
    using System.Web.Routing;

    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Default",
                "",
                new { controller = "ProductOverview", action = "ProductOverview", id = UrlParameter.Optional });

            routes.MapRoute(
                "Detail",
                "Detail/{id}",
                new { controller = "ProductDetail", action = "ProductDetail" });
        }
    }
}