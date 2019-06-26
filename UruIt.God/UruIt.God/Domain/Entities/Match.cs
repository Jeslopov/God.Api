using System;
using System.Collections.Generic;

namespace UruIt.God.Domain.Entities
{
    public class Match : BaseEntity
    {
        public Match()
        {
            Rounds = new List<Round>();
        }

        public virtual User Player1 { get; set; }

        public virtual User Player2 { get; set; }

        public int? WinnerId { get; set; }

        public virtual ICollection<Round> Rounds { get; set; }


    }
}
