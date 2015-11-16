using System.Web.Http;
using MVC4WebApi.Filters;
using MVC4WebApi.Models;
using Ninject;
using WebApiContrib.IoC.Ninject;

namespace MVC4WebApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Filters.Add(new ValidateAttribute());

            IKernel kernel = new StandardKernel();
            kernel.Bind<ICustomerRepository>().ToConstant(new InitMockData());
            //LOG INIT !
            log4net.Config.XmlConfigurator.Configure();
            config.DependencyResolver = new NinjectResolver(kernel);

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
                );
        }
    }
}
