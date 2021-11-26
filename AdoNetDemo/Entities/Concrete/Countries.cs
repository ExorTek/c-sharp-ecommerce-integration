using Entities.Abstract;

namespace Entities.Concrete
{
    public class Countries:IEntity
    {
        public int Id { get; set; }
        public string Country { get; set; }

    }
}
