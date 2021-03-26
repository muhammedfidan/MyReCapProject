using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IColorService
    {

        IDataResult<List<Color>> GetAll();

        IResult Update(Color color);
        IResult Delete(Color color);
        IResult Insert(Color color);

        IDataResult<List<Color>> GetAllById(int colorId);
        

    }
}
