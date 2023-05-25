using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Ninject.Modules;
using Ninject.Web.Common;
using PIS_Lab6.Contracts;
using PIS_Lab6.Models;
using Unity.Mvc3;

namespace PIS_Lab6
{
    public class NinjectRegistrations : NinjectModule
    {
        public override void Load()
        {
            
            //Bind<IDbContext>().To<TDDbContext>();

            //�������� - ���� ������ �� �� ����������
            //Bind<ITD>().To<TDDbPhone>().InSingletonScope();

            //����� �������� - �������� ������ � ������ ������ ������
            //Bind<ITD>().To<TDDbPhone>().InThreadScope();

            //�� ���� ���� - ��� ������ http-�������
            //Bind<ITD>().To<TDDbPhone>().InRequestScope();


            //�� ����, ����� ��������� ��������� ������� ��� ������ ���������
            //������������ �� �������
            //Bind<ITD>().To<TDDbPhone>().InTransientScope();


            //json
            Bind<ITD>().To<TD>();
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