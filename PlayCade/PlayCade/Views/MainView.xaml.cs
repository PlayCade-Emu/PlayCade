using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlayCade.ViewModels;
using Xamarin.Forms;

namespace PlayCade.Views
{
    public partial class MainView : ContentPage
    {
        public MainView()
        {
            InitializeComponent();

            var viewModel = new MainViewViewModel();
            viewModel.LabelText = "Hello from ViewModel";

            BindingContext = viewModel;
        }
    }
}