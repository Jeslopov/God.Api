using System;
using UruIt.God.Infraestructure.Abstractions;

namespace UruIt.God.Services.Abstractions
{
    public interface IUnitOfWork: IDisposable
    {
        IUserRepository Users { get; }
        IMatchRepository Matches { get; }
        IRoundRepository Rounds { get; }
        //Commit the changes 
        int Complete();
    }
}
