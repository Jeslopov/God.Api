using System;
using AutoMapper;
using UruIt.God.Domain.Entities;
using UruIt.God.ViewModels;

namespace UruIt.God.Services.Mappings
{
    public class UserProfile: Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserViewModel>();
            CreateMap<UserViewModel, User>();
        }
    }
}
