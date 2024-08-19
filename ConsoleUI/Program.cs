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

List<CarDetailDto> carDetails = carManager.GetCarDetails().Data;

foreach (var carDetail in carDetails)
{
    Console.WriteLine($"Car Description: {carDetail.Description}, Brand Name: {carDetail.BrandName} ,Color: {carDetail.ColorName}");
}


//using (var db = new RentACarContext())
//{
//    var yeniAraba = new Car
//    {

//        BrandId = 4,
//        ColorId = 4,
//        ModelYear = 2020,
//        DailyPrice = 3000,
//        Description = "Konfor isteyenler için"
//    };

//    db.Cars.Add(yeniAraba);
//    db.SaveChanges();
//}

