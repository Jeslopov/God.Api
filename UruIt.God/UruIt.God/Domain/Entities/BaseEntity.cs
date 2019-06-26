using System;
using UruIt.God.Domain.Abstractions;

namespace UruIt.God.Domain.Entities
{
    public abstract class BaseEntity : IEntity
    {
        public int Id { get; set; }
    }
}
