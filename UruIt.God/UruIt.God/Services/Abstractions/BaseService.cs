using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace UruIt.God.Services.Abstractions
{
    public abstract class BaseService
    {
        protected readonly IUnitOfWork _unitOfWork;
        
        public BaseService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
