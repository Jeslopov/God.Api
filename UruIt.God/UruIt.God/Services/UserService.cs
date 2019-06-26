using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using UruIt.God.Domain.Entities;
using UruIt.God.Infraestructure.Abstractions;
using UruIt.God.Infraestructure.DataImplementations;
using UruIt.God.Services.Abstractions;
using UruIt.God.ViewModels;

namespace UruIt.God.Services
{
    public class UserService: BaseService, IUserService
    {
        readonly IUserRepository _userRepository;

        public UserService(IUnitOfWork unitOfWork):base(unitOfWork)
        {
            _userRepository = unitOfWork.Users;
            _unitOfWork.Complete();
        }

        public void Add(User entity)
        {
            _userRepository.Add(entity);
            _unitOfWork.Complete();
        }

        public void AddRange(IEnumerable<User> entities)
        {
            _userRepository.AddRange(entities);
            _unitOfWork.Complete();
        }

        public IEnumerable<User> Find(Expression<Func<User, bool>> predicate)
        {
            var result = _userRepository.Find(predicate);
            _unitOfWork.Complete();
            return result;
        }

        public User Get(int id)
        {
            var result = _userRepository.Get(id);
            _unitOfWork.Complete();
            return result;
        }

        public IEnumerable<User> GetAll()
        {
            var result = _userRepository.GetAll();
            
            return result;
        }

        public IEnumerable<ScoreViewModel> PagedUsersScores(int pageNumber, int pageSize = 10)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ScoreViewModel> UsersScores()
        {
            var users = _userRepository.GetAll();
            List<Match> matches = new List<Match>(_unitOfWork.Matches.GetAll());
            List<ScoreViewModel> scores = new List<ScoreViewModel>();
            foreach (var user in users)
            {
                scores.Add(new ScoreViewModel
                {
                    UserName = user.Name,
                    Score = matches.FindAll(m => m.WinnerId == user.Id).Count
                });
            }
            return scores;
        }
        
    }
}
