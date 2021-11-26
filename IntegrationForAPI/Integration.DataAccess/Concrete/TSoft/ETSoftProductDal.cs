using System.Collections.Generic;
using Integration.Core.Utilities.Helper;
using Integration.DataAccess.Abstract.TSoft;
using Integration.Entities.Concrete.TSoft;
using Newtonsoft.Json;
using RestSharp;

namespace Integration.DataAccess.Concrete.TSoft
{
    public class ETSoftProductDal : ITSoftProductDal
    {
        public TSoftProduct GetAll(int start)
        {
            var client = new RestClient(TSoftConfigurationHelper.ProductUrl);
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddParameter("token", TSoftConfigurationHelper.Token);
            request.AddParameter("limit", TSoftConfigurationHelper.Limit);
            request.AddParameter("start", start);
            request.RequestFormat = DataFormat.Json;
            var response = client.Execute(request);
            return JsonConvert.DeserializeObject<TSoftProduct>(response.Content);
        }
    }
}