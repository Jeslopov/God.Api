using System;
using System.Collections.Generic;
using UruIt.God.Domain.Entities;
using UruIt.God.ViewModels;

namespace UruIt.God.Services.Abstractions
{
    public interface IUserService: IService<User>
    {
        IEnumerable<ScoreViewModel> UsersScores();

        IEnumerable<ScoreViewModel> PagedUsersScores(int pageNumber, int pageSize);
    }
}
