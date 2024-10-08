﻿using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserService 
    {
        IResult Add( User users);
        IResult Delete ( User user );

        IResult Update ( User user );

        IDataResult <List<User>> GetAll ();

        IDataResult<List<User>> GetbyId ( int id );
    }
}
