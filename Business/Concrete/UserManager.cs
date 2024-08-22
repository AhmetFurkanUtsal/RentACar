using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        public Result Add(User users)
        {
            return new Result(true);
        }

        public Result Delete(User user)
        {
            return new Result(true);
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(Messages.Listed);
        }

        public IDataResult<List<User>> GetbyId(int id)
        {
            return new SuccessDataResult<List<User>>();
        }

        public Result Update(User user)
        {
            return new Result(true);
        }
    }
}
