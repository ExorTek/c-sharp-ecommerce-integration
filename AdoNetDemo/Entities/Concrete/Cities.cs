using Entities.Abstract;

namespace Entities.Concrete
{
    public class Cities:IEntity
    {
        public int Id { get; set; }
        public byte CountryId { get; set; }
        public string City { get; set; }
    }
}
