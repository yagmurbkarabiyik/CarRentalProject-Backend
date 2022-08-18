using Business.Abstract;
using Business.Constants;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstract;
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
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void Add(User user)
        {
            _userDal.Add(user);
        }

        //public IResult Delete(User user)
        //{
        //    _userDal.Delete(user);
        //    return new SuccessResult(Messages.UserDeleted);
        //}

        //public IDataResult<List<User>> GetAll()
        //{
        //    var value = _userDal.GetAll();
        //    return new SuccessDataResult<List<User>>(value, Messages.UserGetAll);
        //}

        //public IDataResult<User> GetById(int id)
        //{
        //    var value = _userDal.Get(p => p.Id == id);
        //    return new SuccessDataResult<User>(value, Messages.UserGetById);
        //}

        public User GetByMail(string email)
        {
            return _userDal.Get(p => p.Email == email);
        }

        public List<OperationClaim> GetClaims(User user)
        {
            return _userDal.GetClaims(user);
        }

        //public IResult Update(User user)
        //{
        //    _userDal.Update(user);
        //    return new SuccessResult(Messages.UserUpdated);
        //}
    }
}
