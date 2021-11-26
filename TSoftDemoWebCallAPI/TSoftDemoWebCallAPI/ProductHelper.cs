using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;

namespace TSoftDemoWebCallAPI
{
    public class ProductHelper
    {
        public ProductsDto GetAllProduct(string token)
        {
            var client = new RestClient("https://mehmetdemirel.1ticaret.com/rest1/product/get/");
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddParameter("token", token);
            request.RequestFormat = DataFormat.Json;
            IRestResponse response = client.Execute(request);
            var content = response.Content;
            var product = JsonConvert.DeserializeObject<ProductsDto>(content);
            return product;
        }

    }
}