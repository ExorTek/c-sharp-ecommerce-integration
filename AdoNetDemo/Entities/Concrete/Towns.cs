using Entities.Abstract;

namespace Entities.Concrete
{
    public class Towns:IEntity
    {
        public int Id { get; set; }
        public short CityId { get; set; }
        public string Town { get; set; }
    }
}
