using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;

namespace TSoftAddProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> product = new List<Product>();
            Random rnd = new Random();
            for (int i = 760; i < 2000; i++)
            {
                product.Add(new Product()
                {
                    Barcode = $"RANDOMURUN{i}",
                    Currency = "TL",
                    DefaultCategoryCode = "T286",
                    ProductCode = $"T{900 + i}",
                    ProductName = $"Memet Ürün {i}",
                    SellingPrice = $"{rnd.Next(1, 6000)}",
                    Stock = $"{rnd.Next(1, 50)}"
                });
                if (i % 100 == 0)
                {
                    var client = new RestClient("http://erp-oguzhanodabasi.1ticaret.com/rest1/product/createProducts");
                    var request = new RestRequest(Method.POST);
                    var data = JsonConvert.SerializeObject(product);
                    request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
                    request.AddParameter("token", "393e42435e4dcf84d5b00284c0de47ba");
                    request.AddParameter("data", data);
                    client.Execute(request);
                }
            }
        }
    }


    class Product
    {
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string DefaultCategoryCode { get; set; }
        public string Barcode { get; set; }
        public string Stock { get; set; }
        public string SellingPrice { get; set; }
        public string Currency { get; set; }
    }
}