using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _color;

        public ColorManager(IColorDal color)
        {
            _color = color;
        }

        public void Add(Color color)
        {
            _color.Add(color);
        }

        public void Delete(Color color)
        {
           _color.Delete(color);
        }

        public List<Color> GetAll()
        {
            return _color.GetAll();
        }

        public List<Color> GetByColorId(int id)
        {
            return _color.GetAll(c=>c.ColorId == id);
        }

        public List<Color> GetCarByBrandId(int id)
        {
           return _color.GetAll(c=>c.ColorId== id);
        }

        public void Update(Color color)
        {
            _color.Update(color);
        }
    }
}
