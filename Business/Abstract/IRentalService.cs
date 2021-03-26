using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IResult Insert(Rental rental);
        IResult Delete(Rental rental);
        IResult Update(Rental rental);
    }
}
