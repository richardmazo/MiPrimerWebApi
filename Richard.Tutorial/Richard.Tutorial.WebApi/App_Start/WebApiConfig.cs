using System.Web.Http;
using Richard.Tutorial.Middleware;
using System.Reflection;
using Autofac;
using Autofac.Integration.WebApi;

namespace Richard.Tutorial.WebApi
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
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            AutoMapperSetup.SetUpAutoMapper();
           ContainerBuilder builder = AutoFacSetup.SetupAutoFac(Assembly.GetExecutingAssembly());
           IContainer container = builder.Build();

            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);



        }
    }
}
