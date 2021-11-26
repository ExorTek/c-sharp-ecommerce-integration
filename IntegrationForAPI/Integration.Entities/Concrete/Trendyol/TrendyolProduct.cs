using System.Collections.Generic;

namespace Integration.Entities.Concrete.Trendyol
{
    public class TrendyolProduct
    {
        public List<Item> Items { get; set; }

        public class Item
        {
            public string Barcode { get; set; }
            public string ProductName { get; set; }
            public string ProductMainId { get; set; }
            public string Stock { get; set; }
            public string SalePrice { get; set; }
        }
    }
}