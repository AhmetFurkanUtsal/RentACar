using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IColorService
    {
        IDataResult <List<Color>> GetAll();

        Result Add(Color color);

        Result Update(Color color);

        Result Delete(Color color);

        IDataResult <List<Color>> GetCarByBrandId(int id);

        IDataResult <List<Color>> GetByColorId(int id);
    }
}
