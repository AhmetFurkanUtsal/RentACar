﻿using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        private EfBrandDal efBrandDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

  
        public IResult Add(Car car)
        {
            if (car.DailyPrice>0 && car.Description.Length>=2)
            {
                return new ErrorResult(Messages.Error);
            }
        
            return new SuccessResult(Messages.ProductAdded);
        }

        public IResult Delete(Car car)
        {
           _carDal.Delete(car);
            return new Result(true,"");
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), true, "Ürünler listelendi");
        }

      

        public IDataResult<List<Car>> GetByColorId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.ColorId == id));
        }



        public IDataResult<List<Car>> GetCarByBrandId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c=> c.BrandId == id)); 
        }

        public IDataResult<List<CarDetailDto>>GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails());
        }

        public IResult Update(Car car)
        {
           _carDal.Update(car);
            return new SuccessResult(""); 
        }
    }
}
