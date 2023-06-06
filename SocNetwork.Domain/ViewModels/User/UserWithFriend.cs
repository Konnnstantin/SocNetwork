using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocNetwork.Domain.ViewModels.User
{
   public class UserWithFriend : SocNetwork.Domain.Entity.User
    {
        public bool IsFriend { get; set; }
    }
}
