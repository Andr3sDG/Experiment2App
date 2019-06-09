using Experiment2.Model;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace Experiment2.ViewModel
{
    class ApiController
    {

        public void CreateClient(ClientModel client)
        {
            var RestClient = new RestClient("https://www.experiment2.io/");
            var Request = new RestRequest("api/Account/Register", Method.POST);

            //Add HTTP Headers
            Request.AddHeader("Content-Type", "application/json");
            Request.AddJsonBody(client);

            //Excecute the request
            IRestResponse Response = RestClient.Execute(Request);
            var Content = Response.Content;
            Console.WriteLine(Content);
        }

    }
}
