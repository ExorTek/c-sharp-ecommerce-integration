using System;
using Entities.Abstract;

namespace Entities.Concrete
{
    public  class Invoices:IEntity
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public DateTime Date { get; set; }
        public int AddressId { get; set; }
        public string CargoFicheNo { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
