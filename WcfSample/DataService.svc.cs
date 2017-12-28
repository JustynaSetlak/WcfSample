using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfSample
{
    public class DataService : IDataService
    {
        public string GetData()
        {
            var textMessage = "Hello from WCF";
            return textMessage;
        }
    }
}
