using System;
using System.Threading.Tasks;
using PlayCade.Interfaces;
using PlayCade.ViewModels.Base;

namespace PlayCade.ViewModels
{
    public class LayoutViewModel: ViewModelBase
    {
        public LayoutViewModel(INavigationService navigationService) : base(navigationService)
        {
        }
    }
}
