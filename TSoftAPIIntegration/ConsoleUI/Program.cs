using System;
using TSoft.Business.Concrete;
using TSoft.Business.Concrete.TSoft;
using TSoft.Core.Utilities.Helper;
using TSoft.DataAccess.Concrete;
using TSoft.DataAccess.Concrete.TSoft;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            UserManager userManager = new UserManager(new EUserDal());
            var user = userManager.Login();
            Console.WriteLine("User :" + user.Data[0].Username);
            Console.WriteLine("Success: " + user.Success);
            ProductManager productManager = new(new EProductDal());
            var products = productManager.GetAll();
            TSoftConfigurationHelper.Token = user.Data[0].Toksen;
            Console.WriteLine("Name :" + products.Data[0].ProductName);
            Console.WriteLine("Stock: " + products.Data[0].Stock);
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Name :" + products.Data[1].ProductName);
            Console.WriteLine("Stock: " + products.Data[1].Stock);
            Console.ReadKey();
        }
    }
}