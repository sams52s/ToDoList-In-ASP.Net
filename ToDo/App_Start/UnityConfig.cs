using System.Web.Mvc;
using Unity;
using Unity.Mvc5;
using BLL;

namespace ToDo
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IAdmin, Admin>();
            container.RegisterType<IToDo, _ToDo>();


            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}