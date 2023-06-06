using AutoMapper;
using SocNetwork.Domain;
using SocNetwork.Domain.Entity;
using SocNetwork.Domain.ViewModels.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocNetwork.DAL.AutoMapper
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<RegisterViewModel, User>()
                 .ForMember(x => x.BirthDate, opt => opt.MapFrom(c => new DateTime((int)c.Year, (int)c.Month, (int)c.Date)))
                 .ForMember(x => x.Email, opt => opt.MapFrom(c => c.EmailReg))
                 .ForMember(x => x.UserName, opt => opt.MapFrom(c => c.Login));
            CreateMap<LoginViewModel, User>();

            CreateMap<UserEditViewModel, User>();
            CreateMap<User, UserEditViewModel>().ForMember(x => x.UserId, opt => opt.MapFrom(c => c.Id));

            CreateMap<UserWithFriend, User>();
            CreateMap<User, UserWithFriend>();
        }
    }
}
