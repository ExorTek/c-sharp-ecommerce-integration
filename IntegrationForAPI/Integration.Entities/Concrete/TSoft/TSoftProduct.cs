using System.Collections;
using System.Collections.Generic;
using Integration.Core.Entities;

namespace Integration.Entities.Concrete.TSoft
{
    public class TSoftProduct : IEntity
    {
        public bool Success { get; set; }
        public ProductData[] Data { get; set; }
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