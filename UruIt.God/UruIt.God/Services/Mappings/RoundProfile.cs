using System;
using AutoMapper;
using UruIt.God.Domain.Entities;
using UruIt.God.ViewModels;

namespace UruIt.God.Services.Mappings
{
    public class RoundProfile: Profile
    {
        public RoundProfile()
        {
            CreateMap<Round, RoundViewModel>();
            CreateMap<RoundViewModel, Round>();
        }
    }
}
