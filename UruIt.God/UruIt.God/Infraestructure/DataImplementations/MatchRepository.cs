using System;
using Microsoft.EntityFrameworkCore;
using UruIt.God.Domain.Entities;
using UruIt.God.Infraestructure.Abstractions;

namespace UruIt.God.Infraestructure.DataImplementations
{
    public class MatchRepository: BaseRepository<Match>, IMatchRepository
    {
        public MatchRepository(DbContext context) : base(context)
        {
        }
    }
}
