using Experiment2.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Experiment2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void SelectUserTypeButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SelectUserType());
        }

        private void SignInEmailButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EmailAuth());
        }
    }
}
