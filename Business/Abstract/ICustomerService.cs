using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        IResult Update(Customer customer);
        IResult Delete(Customer customer);
        IResult Insert(Customer customer);
    }
}
