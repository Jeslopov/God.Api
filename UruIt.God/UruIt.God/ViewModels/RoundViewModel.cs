using System;
using UruIt.God.Domain.Entities;

namespace UruIt.God.ViewModels
{
    public class RoundViewModel: BaseViewModel
    {
        public RoundViewModel()
        {
        }

        public virtual Match Match { get; set; }

        public virtual User Winner { get; set; }
    }
}
