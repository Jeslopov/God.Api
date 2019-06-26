using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using UruIt.God.Domain.Entities;
using UruIt.God.Infraestructure.Abstractions;
using UruIt.God.Services.Abstractions;

namespace UruIt.God.Services
{
    public class RoundService: BaseService, IRoundService
    {
        private readonly IRoundRepository _roundRepository; 
        public RoundService(IUnitOfWork unitOfWork): base(unitOfWork)
        {
            _roundRepository = _unitOfWork.Rounds;
        }

        public void Add(Round entity)
        {
            _roundRepository.Add(entity);
        }

        public void AddRange(IEnumerable<Round> entities)
        {
            _roundRepository.AddRange(entities);
        }

        public IEnumerable<Round> Find(Expression<Func<Round, bool>> predicate)
        {
            return _roundRepository.Find(predicate);
        }

        public Round Get(int id)
        {
            return _roundRepository.Get(id);
        }

        public IEnumerable<Round> GetAll()
        {
            return _roundRepository.GetAll();
        }
    }
}
