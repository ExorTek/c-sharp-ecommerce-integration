using System;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class Payments:IEntity
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public byte PaymentType { get; set; }
        public DateTime Date { get; set; }
        public bool IsOk { get; set; }
        public string ApproveCode { get; set; }
        public decimal PaymentTotal { get; set; }   
    }
}
