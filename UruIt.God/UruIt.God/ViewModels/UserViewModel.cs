using System;
using System.Collections.Generic;
using UruIt.God.Domain.Entities;

namespace UruIt.God.ViewModels
{
    public class UserViewModel: BaseViewModel
    {
        public UserViewModel()
        {
        }

        public string Name { get; set; }

        public virtual ICollection<Match> Matches { get; set; }
    }
}
