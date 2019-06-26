using System;
using Microsoft.EntityFrameworkCore;
using UruIt.God.Domain.Entities;
using UruIt.God.Infraestructure.Abstractions;

namespace UruIt.God.Infraestructure.DataImplementations
{
    public class RoundRepository: BaseRepository<Round>, IRoundRepository
    {
        public RoundRepository(DbContext context): base(context)
        {
        }
    }
}
