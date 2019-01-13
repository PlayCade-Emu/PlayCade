using System;
using System.Threading.Tasks;
using PlayCade.Interfaces;
using PlayCade.ViewModels.Base;

namespace PlayCade.ViewModels
{
    public class MainViewModel: ViewModelBase
    {
        public string LabelText { get; set; } = "Welcome to PlayCade!";

        public MainViewModel(INavigationService navigationService) : base(navigationService)
        {
           
        }
    }
}
