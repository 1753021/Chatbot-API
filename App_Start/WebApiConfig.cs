﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace IT_Career_Counseling
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "itcareercounseling.azurewebsites.net/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
