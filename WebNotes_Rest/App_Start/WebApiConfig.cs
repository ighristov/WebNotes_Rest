﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace WebNotes_Rest
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            //config.Routes.MapHttpRoute(
            //    name: "DefaultApi",
            //    routeTemplate: "api/{controller}/{id}",
            //    defaults: new { controller = "api", id = RouteParameter.Optional }
            //);
        }
    }
}
