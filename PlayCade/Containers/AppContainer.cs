using System;
using Autofac;
using PlayCade.Interfaces;
using PlayCade.Services;
using PlayCade.ViewModels;

namespace PlayCade.Containers
{
    public class AppContainer
    {
        private static IContainer _container;

        public static void Initialize()
        {
            var builder = new ContainerBuilder();

            // ViewModels
            builder.RegisterType<MainViewModel>();

            //Services
            builder.RegisterType<NavigationService>().As<INavigationService>();

            _container = builder.Build();
        }

        public static object Resolve(Type typeName)
        {
            return _container.Resolve(typeName);
        }

        public static T Resolve<T>()
        {
            return _container.Resolve<T>();
        }
    }
}
