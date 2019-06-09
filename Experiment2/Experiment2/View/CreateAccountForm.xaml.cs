using Experiment2.Model;
using Experiment2.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Experiment2.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CreateAccountForm : ContentPage
	{
        private ClientModel Client;
        private ClientController ClientController;

        public CreateAccountForm ()
		{
			InitializeComponent ();
		}

        private void CreateUserButton_Clicked(object sender, EventArgs e)
        {
            Client = new ClientModel();
            ClientController = new ClientController();
            Client.Username = Username.Text;
            Client.Email = Email.Text;
            Client.Password = Password.Text;
            Client.ConfirmPassword = ConfirmPassword.Text;
            ClientController.CreateUserAction(Client);
        }
    }
}