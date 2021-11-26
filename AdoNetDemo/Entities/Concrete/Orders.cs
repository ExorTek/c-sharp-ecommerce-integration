using System;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class Orders:IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalPrice { get; set; }
        public byte Status { get; set; }
        public int AddressId { get; set; }
    }
}
