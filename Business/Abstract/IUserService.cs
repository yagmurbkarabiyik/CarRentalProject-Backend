using Core.Entities.Concrete;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
   public interface IUserService
    {
        //List<OperationClaim> GetClaims(User user);

        //IDataResult<List<User>> GetAll();
        //IDataResult<User> GetById(int id);
        void Add(User user);
        //IResult Update(User user);
        //IResult Delete(User user);
        User GetByMail(string email);
        List<OperationClaim> GetClaims(User user);

    }
}
