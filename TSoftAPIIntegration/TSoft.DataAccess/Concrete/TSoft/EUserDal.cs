using Newtonsoft.Json;
using RestSharp;
using TSoft.Core.Utilities.Helper;
using TSoft.DataAccess.Abstract.TSoft;
using TSoft.Entities.Concrete.TSoft;

namespace TSoft.DataAccess.Concrete.TSoft
{
    public class EUserDal : IUserDal
    {
        //public User Login()
        //{
        //    var client =new RestClient("https://mehmetdemirel.1ticaret.com/rest1/auth/login/postman");
        //    var request = new RestRequest(Method.POST);
        //    request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
        //    request.AddParameter("pass", "Postman01");
        //    var response = client.Execute(request);
        //    request.RequestFormat = DataFormat.None;
        //    return JsonConvert.DeserializeObject<User>(response.Content);
        //}


        User IUserDal.Login()
        {
            var client = new RestClient(TSoftConfigurationHelper.LoginUrl + TSoftConfigurationHelper.UserName) ;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddParameter("pass", TSoftConfigurationHelper.Password);
            request.RequestFormat = DataFormat.Json;
            var response = client.Execute(request);
            return JsonConvert.DeserializeObject<User>(response.Content);

        }
    }
}