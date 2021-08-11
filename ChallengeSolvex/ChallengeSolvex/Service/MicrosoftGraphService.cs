using ChallengeSolvex.Models;
using Microsoft.IdentityModel.Clients.ActiveDirectory;

using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.IO;
using System.Text;
using Azure.Identity;
using Microsoft.Graph;

namespace ChallengeSolvex.Service
{
    public class MicrosoftGraphService
    {
        public static string clientId = "f1360e90-e26b-4d19-a607-5d05958b48b6";
        public static string tenantId = "578d6710-bea2-4dcd-b757-730444690809";
        public static string clientSecret = "h0iXL_LY03dsyrwW9.bRwM98M_.8FMmuc3";

        public async Task<IGraphServiceUsersCollectionPage> GetAllUsers()
        {
            var clientSecretCredentials = new ClientSecretCredential(tenantId, clientId, clientSecret);
            var graphClient = new GraphServiceClient(clientSecretCredentials);
            var users = await graphClient.Users.Request().GetAsync();
            return users;
        }


    }
}
