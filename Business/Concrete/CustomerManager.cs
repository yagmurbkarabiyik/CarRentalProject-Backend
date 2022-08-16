using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public IResult Add(Customer customer)
        {
            _customerDal.Add(customer);
            return new SuccessResult(Messages.CustomerAdded);
        }

        public IResult Delete(Customer customer)
        {
            _customerDal.Delete(customer);
            return new SuccessResult(Messages.CustomerDeleted);
        }

        public IDataResult<List<Customer>> GetAll()
        {
            var value = _customerDal.GetAll();
            return new SuccessDataResult<List<Customer>>(value, Messages.CustomerGetAll);
        }

        public IDataResult<Customer> GetById(int id)
        {
            var value = _customerDal.Get(p => p.CustomerId == id);
            return new SuccessDataResult<Customer>(value, Messages.CustomerGetById);
        }

        public IDataResult<List<CustomerDetailDto>> GetCustomerDetails()
        {
            var value = _customerDal.GetCustomerDetails();
            return new SuccessDataResult<List<CustomerDetailDto>>(value, Messages.CustomerDetail);
        }

        public IResult Update(Customer customer)
        {
            _customerDal.Update(customer);
            return new SuccessResult(Messages.CustomerUpdated);
        }
    }
}
