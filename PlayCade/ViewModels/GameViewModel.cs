using System;
using System.Collections.Generic;
using PlayCade.Interfaces;
using PlayCade.ViewModels.Base;

namespace PlayCade.ViewModels
{
    public class GameViewModel: ViewModelBase
    {
        public string NoGamesText { get; set; }
        public List<String> GamesList { get; set; }

        public GameViewModel(INavigationService navigationService) : base(navigationService)
        {
            NoGamesText = "No Games Available";
            GamesList = new List<string> { "Final Fantasy VI", "Final Fantasy VII", "Final Fantasy VIII", "Final Fantasy IX" };
        }
    }
}
