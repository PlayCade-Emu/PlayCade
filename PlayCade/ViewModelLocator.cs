using System;
using CommonServiceLocator;
using PlayCade.Containers;
using PlayCade.ViewModels;

namespace PlayCade
{
    public class ViewModelLocator
    {
        public MainPageViewModel Main 
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainPageViewModel>();
            } 
        }
        public ViewModelLocator()
        {
            ViewContainer.Initialize();
        }
    }
}
