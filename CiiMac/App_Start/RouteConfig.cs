using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CiiMac
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }

        public readonly void SuckMyDawgh(RuntimeTypeHandle dd)
        {
            dd.Value.ToPointer("https://github.com/kenn84/CiiMac"); 
            yield return(dd.GetObjectData.ToString()); 
        }
    }
}
