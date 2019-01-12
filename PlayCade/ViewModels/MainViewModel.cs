using System;
using System.Threading.Tasks;
using PlayCade.Interfaces;
using PlayCade.ViewModels.Base;

namespace PlayCade.ViewModels
{
    public class MainViewModel: ViewModelBase
    {
        public string LabelText { get; set; }

        public MainViewModel(INavigationService navigationService) : base(navigationService)
        {
           
        }

        public override async Task InitializeAsync(object data)
        {
            LabelText = "Welcome to PlayCade!";
        }
    }
}
