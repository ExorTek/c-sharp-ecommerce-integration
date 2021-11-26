using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSoftDemoWebCallAPI
{
   
        public  class UserDto
        {
            public bool Success { get; set; }
            public Datum[] Data { get; set; }
            public Message[] Message { get; set; }
            public string Summary { get; set; }
        }

        public  class Datum
        {
            public long UserId { get; set; }
            public string Username { get; set; }
            public string Token { get; set; }
            public string SecretKey { get; set; }
            public string ExpirationTime { get; set; }
            public long Limited { get; set; }
            public string Type { get; set; }
            public long TableId { get; set; }
        }

        public  class Message
        {
            public long Type { get; set; }
            public string Code { get; set; }
            public long Index { get; set; }
            public long Id { get; set; }
            public string Subid { get; set; }
            public string[] Text { get; set; }
            public object[] ErrorField { get; set; }
        }
}
