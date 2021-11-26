using Entities.Abstract;

namespace Entities.Concrete
{
    public class Items:IEntity
    {
        public int Id { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public float UnitPrice { get; set; }
        public string Category1 { get; set; }
        public string Category2 { get; set; }
        public string Category3 { get; set; }
        public string Category4 { get; set; }
        public string Brand { get; set; }
    }
}
