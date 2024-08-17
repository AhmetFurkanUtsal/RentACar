// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;




//CarManager carManager = new CarManager(new EfCarDal());

//foreach (var car in carManager.GetAll())
//{
//    Console.WriteLine( );
//}

//BrandManager brandManager = new BrandManager(new EfBrandDal());
//{
//    foreach (var brand in brandManager.GetAll())
//    {
//        Console.WriteLine(brand.BrandName);
//    }
//}



CarManager carManager = new CarManager(new EfCarDal());

List<CarDetailDto> carDetails = carManager.GetCarDetails();

foreach (var carDetail in carDetails)
{
    Console.WriteLine($"Car Description: {carDetail.Description}, Brand Name: {carDetail.BrandName} ,Color: {carDetail.ColorName}");



    
}

