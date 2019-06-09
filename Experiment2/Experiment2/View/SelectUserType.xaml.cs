using System;
using Experiment2.View;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Experiment2.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SelectUserType : ContentPage
	{
		public SelectUserType ()
		{
			InitializeComponent ();
		}

        private void CreateUserAccountButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CreateAccountForm());
        }

        private void CreateServiceProviderAccountButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CreateAccountForm());
        }
    }
}