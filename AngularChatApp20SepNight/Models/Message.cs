using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularChatApp20SepNight.Models
{
    public class Message
    {
        public int MessageId { get; set; }
        public string MessageText { get; set; }
        public DateTime MessageDate { get; set; }
        public string UserName { get; set; }
        public string ConnectionId { get; set; }
    }
}