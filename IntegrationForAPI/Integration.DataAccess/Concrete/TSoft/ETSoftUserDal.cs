using Integration.Core.Utilities.Helper;
using Integration.DataAccess.Abstract.TSoft;
using Integration.Entities.Concrete.TSoft;
using Newtonsoft.Json;
using RestSharp;
using System.Collections.Generic;
using Integration.Core.Utilities.Result;
using Quartz;

namespace Integration.DataAccess.Concrete.TSoft
{
    public class ETSoftUserDal : ITSoftUserDal
    {

        public TSoftUser Login()
        {
            var client = new RestClient(TSoftConfigurationHelper.LoginUrl + TSoftConfigurationHelper.UserName);
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddParameter("pass", TSoftConfigurationHelper.Password);
            request.RequestFormat = DataFormat.Json;
            var response = client.Execute(request);
            return JsonConvert.DeserializeObject<TSoftUser>(response.Content);
        }
    }
}