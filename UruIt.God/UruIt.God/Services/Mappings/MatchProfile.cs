using System;
using System.Text.RegularExpressions;
using AutoMapper;
using UruIt.God.ViewModels;

namespace UruIt.God.Services.Mappings
{
    public class MatchProfile: Profile
    {
        public MatchProfile()
        {
            CreateMap<Match, MatchViewModel>();
            CreateMap<MatchViewModel, Match>();
        }
    }
}
