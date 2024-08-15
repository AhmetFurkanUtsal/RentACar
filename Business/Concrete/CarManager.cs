﻿using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.DailyPrice>0 && car.Description.Length>=2)
            {
                _carDal.Add(car);
            }
            else
            {
                Console.WriteLine("Günlü kiralama ücreti 0 dan büyük olmalı ve Araç ismi en az 2 karakter olmalı");
            }
        }

        public void Delete(Car car)
        {
           _carDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

      

        public List<Car> GetByColorId(int id)
        {
            return _carDal.GetAll(c => c.ColorId == id);
        }



        public List<Car> GetCarByBrandId(int id)
        {
            return _carDal.GetAll(c=> c.BrandId == id); 
        }

      

        public void Update(Car car)
        {
           _carDal.Update(car);
        }
    }
}
