using System.Collections.Generic;
using Integration.Core.Entities;

namespace Integration.Entities.Concrete.TSoft
{
    public class TSoftUser : IEntity
    {
        public bool Success { get; set; }
        public List<UserData> Data { get; set; }
    }

    public class UserData
    {
        public string Username { get; set; }
        public string Token { get; set; }
        public string SecretKey { get; set; }
        public string Type { get; set; }
    }
}