using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using AutoMapper;
using Integration.Business.Concrete;
using Integration.Business.Concrete.TSoft;
using Integration.DataAccess.Concrete.EntityFramework;
using Integration.DataAccess.Concrete.TSoft;
using Integration.Entities.Concrete.DataBase;
using Integration.Entities.Concrete.DTOs;
using Integration.Entities.Concrete.TSoft;
using Quartz;

namespace DemoConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            TSoftProductManager tSoftProductManager = new TSoftProductManager(new ETSoftProductDal());
            int start = 0;
            while (start >= 0)
            {
                var product = tSoftProductManager.GetAll(start);
                if (product.Data.Length != 250)
                {
                    break;
                }
                foreach (var prod in product.Data)
                {
                    productManager.Add(new Product()
                    {
                        ProductName = prod.ProductName,
                        Barcode = prod.Barcode,
                        ProductCode = prod.ProductCode,
                        ProductId = prod.ProductId,
                        SellingPrice = prod.SellingPrice,
                        Stock = prod.Stock,
                    });
                }

                start += 250;
            }

            Console.ReadKey();
        }
    }
}