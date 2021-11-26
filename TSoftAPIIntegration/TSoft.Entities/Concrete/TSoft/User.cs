using System.Collections.Generic;
using TSoft.Core.Entities;

namespace TSoft.Entities.Concrete.TSoft
{
    public class User : IEntitiy
    {
        public bool Success { get; set; }
        public List<UserData> Data { get; set; }
    }

    public  class UserData
    {
        public string Username { get; set; }
        public string Toksen { get; set; }
        public string SecretKey { get; set; }
        public string Type { get; set; }
    }

  
}