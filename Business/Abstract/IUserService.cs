using Core.Entities.Concrete;
using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<User>> GetAll();
        IDataResult<User> GetByUserId(int userId);

        IDataResult<User> GetByMail(string email);

        List<OperationClaim> GetClaims(User user);
        IResult Add(User user);
        IResult Update(User user);
        IResult Delete(User user);

        User GetUserObjectByMail(string email);
    }
}
