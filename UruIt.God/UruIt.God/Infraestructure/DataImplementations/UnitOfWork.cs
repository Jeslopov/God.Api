using System;
using UruIt.God.Infraestructure.Abstractions;
using UruIt.God.Infraestructure.DbContexts;
using UruIt.God.Services.Abstractions;

namespace UruIt.God.Infraestructure.DataImplementations
{
    public class UnitOfWork: IUnitOfWork
    {
        private readonly AppDbContext _context;

        public UnitOfWork(AppDbContext dbContext)
        {
            _context = dbContext;
            Users = new UserRepository(_context);
            Matches = new MatchRepository(_context);
            Rounds = new RoundRepository(_context);
        }

        public IUserRepository Users { get; private set; }

        public IMatchRepository Matches { get; private set; }

        public IRoundRepository Rounds { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
