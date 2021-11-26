using System.Diagnostics;
using Newtonsoft.Json;
using RestSharp;

namespace TSoftDemoWebCallAPI
{
    public class LoginHelper
    {
        public UserDto Login(string userName)
        {
            var client = new RestClient("https://mehmetdemirel.1ticaret.com/rest1/auth/login/"+userName);
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddParameter("pass", "Postman01");
            request.RequestFormat = DataFormat.Json;
            IRestResponse response = client.Execute(request);
            var content = response.Content;
            var user = JsonConvert.DeserializeObject<UserDto>(content);
            return user;
            
        }
    }
}
