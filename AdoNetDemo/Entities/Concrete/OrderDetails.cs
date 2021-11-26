using Entities.Abstract;

namespace Entities.Concrete
{
    public class OrderDetails:IEntity
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ItemId { get; set; }
        public int Amount { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal LineTotal { get; set; }
    }
}
