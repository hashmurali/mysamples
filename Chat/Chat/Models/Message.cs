using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Models
{
   public class Message
    {
        public string Id { get; set; }
        public string ConversationId { get; set; }
        public string UserId { get; set; }
        public string Username { get; set; }
        public string Text { get; set; }
    }
}
