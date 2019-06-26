using System;
using Microsoft.EntityFrameworkCore;
using UruIt.God.Domain.Entities;
using UruIt.God.Infraestructure.Abstractions;

namespace UruIt.God.Infraestructure.DataImplementations
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(DbContext context): base(context)
        {
        }
    }
}
