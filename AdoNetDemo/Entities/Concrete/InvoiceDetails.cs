using Entities.Abstract;

namespace Entities.Concrete
{
    public class InvoiceDetails:IEntity
    {
        public int Id { get; set; }
        public int InvoiceId { get; set; }
        public int OrderDetailId { get; set; }
        public int ItemId { get; set; }
        public int Amount { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal LineTotal { get; set; }
    }
}
