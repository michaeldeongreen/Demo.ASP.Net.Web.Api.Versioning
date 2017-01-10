using Microsoft.Owin;
using Microsoft.Web.Http.Routing;
using Newtonsoft.Json.Serialization;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Http;
using System.Web.Http.Routing;

[assembly: OwinStartup(typeof(Demo.ASP.Net.Web.Api.Versioning.Api.Startup))]
namespace Demo.ASP.Net.Web.Api.Versioning.Api
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            HttpConfiguration config = new HttpConfiguration();

            /*
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );*/

            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));
            config.Formatters.JsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            config.Formatters.JsonFormatter.UseDataContractJsonSerializer = false;

            DefaultInlineConstraintResolver constraintResolver = new DefaultInlineConstraintResolver() { ConstraintMap = { ["apiVersion"] = typeof(ApiVersionRouteConstraint) } };
            config.AddApiVersioning(o => o.ReportApiVersions = true);
            config.MapHttpAttributeRoutes(constraintResolver);
            app.UseWebApi(config);
        }
    }
}