using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IColorService
    {

        List<Color> GetAll();
        void Update(Color color);
        void Delete(Color color);
        void Insert(Color color);
        Color GetById(int colorId);

    }
}
