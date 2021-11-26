using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integration.Entities.Concrete.DTOs
{
    public class TSoftProductDto
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
