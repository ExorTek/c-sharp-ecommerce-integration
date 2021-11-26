using System;
using System.Collections.Generic;
using TSoft.Core.Entities;

namespace TSoft.Entities.Concrete.TSoft
{
    public class Product : IEntitiy
    {
        public bool Success { get; set; }
        public List<ProductData> Data { get; set; }
    }

    public class ProductData
    {
        public string ProductId { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string Barcode { get; set; }
        public string Stock { get; set; }
        public string SellingPrice { get; set; }
    }

}