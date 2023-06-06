using SocNetwork.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocNetwork.Domain.ViewModels.User
{
   public class ChatViewModel
    {
        public SocNetwork.Domain.Entity.User You { get; set; }

        public SocNetwork.Domain.Entity.User ToWhom { get; set; }

        public List<Message> History { get; set; }

        public MessageViewModel NewMessage { get; set; }

        public ChatViewModel()
        {
            NewMessage = new MessageViewModel();
        }
    }
}
