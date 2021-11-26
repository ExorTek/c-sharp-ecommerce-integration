using Newtonsoft.Json;
using RestSharp;
using TSoft.Core.Utilities.Helper;
using TSoft.DataAccess.Abstract;
using TSoft.DataAccess.Abstract.TSoft;
using TSoft.Entities.Concrete.TSoft;

namespace TSoft.DataAccess.Concrete.TSoft
{
    public class EProductDal : IProductDal
    {
        public Product GetAll()
        {
            var client = new RestClient(TSoftConfigurationHelper.ProductUrl);
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddParameter("token", TSoftConfigurationHelper.Token);
            request.AddParameter("limit", 500);
            request.AddParameter("start", 0);
            request.RequestFormat = DataFormat.Json;
            var response = client.Execute(request);
            return JsonConvert.DeserializeObject<Product>(response.Content);
        }
    }
}