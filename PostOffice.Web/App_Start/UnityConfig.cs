using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc5;
using PostOffice.Domain.Services;
using PostOffice.Service;

namespace PostOffice.Web
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            container.RegisterType<IPostOfficeService, PostOfficeService>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}