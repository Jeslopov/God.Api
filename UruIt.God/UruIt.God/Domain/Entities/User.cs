using System;
using System.Collections.Generic;

namespace UruIt.God.Domain.Entities
{
    public class User : BaseEntity
    {
        public User()        {
            Matches = new List<Match>();
        }

        public string Name { get; set; }

        public virtual ICollection<Match> Matches { get; set; }
    }
    
}
