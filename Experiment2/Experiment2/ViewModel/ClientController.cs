using Experiment2.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Experiment2.ViewModel
{
    class ClientController
    {
        private ApiController Api;

        public void CreateUserAction(ClientModel Client)
        {
            Api = new ApiController();
            Api.CreateClient(Client);
        }

    }
}
