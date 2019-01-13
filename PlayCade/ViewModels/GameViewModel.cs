using System;
using PlayCade.Interfaces;
using PlayCade.ViewModels.Base;

namespace PlayCade.ViewModels
{
    public class GameViewModel: ViewModelBase
    {
        public string ContentText { get; set; } = "Game View";

        public GameViewModel(INavigationService navigationService) : base(navigationService)
        {

        }
    }
}
