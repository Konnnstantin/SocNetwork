using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocNetwork.Domain.ViewModels.User
{
    public class UserViewModel
    {
        public SocNetwork.Domain.Entity.User User { get; set; }

        public UserViewModel(SocNetwork.Domain.Entity.User user)
        {
            User = user;
        }
        public List<SocNetwork.Domain.Entity.User> Friends { get; set; }
    }
}
