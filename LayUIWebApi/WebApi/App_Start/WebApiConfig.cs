using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.ExceptionHandling;
using WebApi.Utility.Filter;

namespace WebApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API 配置和服务

            // Web API 路由
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            //config.Filters.Add(new CustomBasicAuthorizeAttribute());

            config.Filters.Add(new CustomActionFilterAttribute());

            config.Filters.Add(new CustomExceptionFilterAttribute());


            //config.Services.Replace(typeof(IExceptionHandler), new CustomExceptionHandlerAttribute());


            config.EnableCors(new EnableCorsAttribute("*", "*", "*"));
        }
    }
}
