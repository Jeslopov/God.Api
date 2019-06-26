using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using UruIt.God.Domain.Entities;
using UruIt.God.Infraestructure.Abstractions;
using UruIt.God.Services.Abstractions;

namespace UruIt.God.Services
{
    public class MatchService : BaseService, IMatchService
    {
        private readonly IMatchRepository _matchRepository;
        public MatchService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _matchRepository = _unitOfWork.Matches;
        }

        public void Add(Match entity)
        {
            _matchRepository.Add(entity);
        }

        public void AddRange(IEnumerable<Match> entities)
        {
            _matchRepository.AddRange(entities);
        }

        public IEnumerable<Match> Find(Expression<Func<Match, bool>> predicate)
        {
            return _matchRepository.Find(predicate);
        }

        public Match Get(int id)
        {
            return _matchRepository.Get(id);
        }

        public IEnumerable<Match> GetAll()
        {
            return _matchRepository.GetAll();
        }
    }
}
