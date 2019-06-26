using System;
namespace UruIt.God.Domain.Entities
{
    public class Round : BaseEntity
    {
        public virtual Match Match { get; set; }

        public virtual User Winner { get; set; }
    }
}
