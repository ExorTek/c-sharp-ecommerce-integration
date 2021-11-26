using System;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class User : IEntity
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string NameSurname { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string BirthDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public string TelephoneNumber1 { get; set; }
        public string TelephoneNumber2 { get; set; }
    }
}