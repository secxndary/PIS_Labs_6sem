using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Ninject.Modules;
using pis2.Contracts;
using pis2.Models;
using Unity.Mvc3;


namespace pis2
{
    public class NinjectRegistrations : NinjectModule
    {
        public override void Load()
        {

            Bind<IDbContext>().To<TDDbContext>();

            //Очевидно - один объект на всё приложение
            //Bind<ITD>().To<TDDbPhone>().InSingletonScope();

            //Опять очевидно - работает только в рамках одного потока
            //Bind<ITD>().To<TDDbPhone>().InThreadScope();

            //Ну прям база - для одного http-запроса
            //Bind<ITD>().To<TDDbPhone>().InRequestScope();


            //По сути, будет создавать отдельные объекты под каждое внедрение
            //Используется по дефолту
            Bind<ITD>().To<TDDbPhone>().InTransientScope();


            //json
            //Bind<ITD>().To<TD>();
        }
    }

    public static class Bootstrapper
    {
        public static void Initialise()
        {
            var container = BuildUnityContainer();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();

            container.RegisterType<IDbContext, TDDbContext>();

            container.RegisterType<ITD, TDDbPhone>();

            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();            

            return container;
        }
    }
}