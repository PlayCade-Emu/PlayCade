using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PlayCade.Views
{
    public partial class PCNavigationPage : NavigationPage
    {
        public PCNavigationPage()
        {
            InitializeComponent();
        }

        public PCNavigationPage(Page root) : base(root)
        {
            InitializeComponent();
        }
    }
}
