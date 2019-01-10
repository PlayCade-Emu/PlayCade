using System;
using CommonServiceLocator;
using PlayCade.Containers;
using PlayCade.ViewModels;

namespace PlayCade
{
    public class ViewModelLocator
    {
        public MainViewViewModel Main 
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainViewViewModel>();
            } 
        }
        public ViewModelLocator()
        {
            ViewContainer.Initialize();
        }
    }
}
