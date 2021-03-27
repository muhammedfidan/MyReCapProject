using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        IResult Update(Customer customer);
        IResult Delete(Customer customer);
        IResult Insert(Customer customer);
        IDataResult<List<Customer>> GetAll();
        IDataResult<List<Customer>> GetAllById(int id);
    }
}
