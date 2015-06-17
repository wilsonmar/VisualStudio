using Demo.Rest.Mvc.DataAccessLayer;
using Demo.Rest.Mvc.Manager;
using Microsoft.Practices.Unity;
using System.Web.Http;
using Unity.WebApi;

namespace Demo.Rest.Mvc
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers

            container.RegisterType<IDataProvider, DataProvider>();
            container.RegisterType<IEmployeeManager, EmployeeManager>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}