using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Security;
using System.Text;
using System.Threading.Tasks;
using WcfSample.Client.DataService;

namespace WcfSample.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            DataServiceClient dataServiceClient = new DataServiceClient();
            dataServiceClient.ClientCredentials.ServiceCertificate.Authentication.CertificateValidationMode = X509CertificateValidationMode.None;
            dataServiceClient.ClientCredentials.UserName.UserName = "test";
            dataServiceClient.ClientCredentials.UserName.Password = "test123";

            var message = dataServiceClient.GetData();
            Console.WriteLine(message);

            Console.ReadKey();
        }
    }
}
