using System;
using System.Collections.Generic;
using UruIt.God.Domain.Entities;

namespace UruIt.God.ViewModels
{
    public class MatchViewModel: BaseViewModel
    {
        public MatchViewModel()
        {

        }

        

        public virtual User Player1 { get; set; }

        public virtual User Player2 { get; set; }

        public int? WinnerId { get; set; }

        public virtual ICollection<Round> Rounds { get; set; }
    }
}
