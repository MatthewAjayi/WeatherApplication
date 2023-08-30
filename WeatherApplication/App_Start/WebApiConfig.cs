using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace WeatherApplication
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "WeatherApi",
                routeTemplate: "api/weather/{city}",
                defaults: new { controller = "Weather", city = RouteParameter.Optional }
            );
        }
    }
}
