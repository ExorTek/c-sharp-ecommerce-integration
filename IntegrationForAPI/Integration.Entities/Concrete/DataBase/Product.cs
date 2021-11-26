using Integration.Core.Entities;

namespace Integration.Entities.Concrete.DataBase
{
    public class Product:IEntity
    {
        public string ProductId { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string Barcode { get; set; }
        public string Stock { get; set; }
        public string SellingPrice { get; set; }
    }
}