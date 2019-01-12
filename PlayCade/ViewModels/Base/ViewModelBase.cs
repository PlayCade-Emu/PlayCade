using System;
using System.ComponentModel;
using System.Threading.Tasks;
using PlayCade.Interfaces;

namespace PlayCade.ViewModels.Base
{
    public class ViewModelBase
    {
        public ViewModelBase()
        {

        }
        protected readonly INavigationService _navigationService;

        public ViewModelBase(INavigationService navigationService)
        {
            _navigationService = navigationService;

        }

        //private bool _isBusy;

        //public event PropertyChangedEventHandler PropertyChanged;

        //public bool IsBusy
        //{
        //    get => _isBusy;
        //    set
        //    {
        //        _isBusy = value;
        //        OnPropertyChanged(nameof(IsBusy));
        //    }
        //}

        //[NotifyPropertyChangedInvocator]
        //protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //}

        public virtual Task InitializeAsync(object data)
        {
            return Task.FromResult(false);
        }

    }
}

