using System;
using Autofac;
using Autofac.Extras.CommonServiceLocator;
using CommonServiceLocator;
using PlayCade.ViewModels;

namespace PlayCade.Containers
{
    public sealed class ViewContainer
    {
        public static void Initialize()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<MainViewViewModel>().AsSelf();

            var container = builder.Build();

            var autofacServiceLocation = new AutofacServiceLocator(container);

            ServiceLocator.SetLocatorProvider(() => autofacServiceLocation); 
        }
    }
}
