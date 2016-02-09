﻿using TCI.DataAccess;
using TCI.DomainService.Usr.Interface;

namespace TCI.DomainService.Usr
{
    public class UserService : BaseService<Domain.Usr.User>, IUserService
    {
        public UserService(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}
