namespace Integration.Entities.Concrete.Hepsiburada
{
    
        public class HepsiBuradaProduct
        {
            public string CategoryId { get; set; }
            public Attributes Attributes { get; set; }
        }

        public class Attributes
        {
            public string Barcode { get; set; }
            public string ProductName { get; set; }
        }
    
}