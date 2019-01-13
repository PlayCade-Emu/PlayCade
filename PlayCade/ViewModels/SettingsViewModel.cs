using System;
using PlayCade.Interfaces;
using PlayCade.ViewModels.Base;

namespace PlayCade.ViewModels
{
    public class SettingsViewModel: ViewModelBase
    {
        public string ContentText { get; set; } = "Settings View";

        public SettingsViewModel(INavigationService navigationService) : base(navigationService)
        {

        }
    }
}
