using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Routing;
using Microsoft.AspNet.FriendlyUrls;

namespace ASPNetProjectM7
{
    public static class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            var settings = new FriendlyUrlSettings();
            settings.AutoRedirectMode = RedirectMode.Temporary;
            routes.EnableFriendlyUrls(settings);
            routes.MapPageRoute("Object", "Product1", "~/Product1.aspx");
            routes.MapPageRoute("Entity", "Customer1", "~/Customer1.aspx");
            routes.MapPageRoute("OrderInfo", "OrderInfo", "~/OrderInfo.aspx");
        }
    }
}
