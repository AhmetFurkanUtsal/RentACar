using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : ICarDal
    {
        public void Add(Car entity)
        {
            using (RentACarContext context = new RentACarContext()) // performans 
            {
                var addedEntity = context.Entry(entity); // verilen nesneye eriş
                addedEntity.State = Microsoft.EntityFrameworkCore.EntityState.Added;
                // erişilen nesneyi ekle
                context.SaveChanges();
            }
        }

        public void Delete(Car entity)
        {
            using (RentACarContext context = new RentACarContext()) // performans 
            {
                var deletedEntity = context.Entry(entity); // verilen nesneye eriş
                deletedEntity.State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                // erişilen nesneyi ekle
                context.SaveChanges();
            }
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            using (RentACarContext context = new RentACarContext())
            {
                return context.Set<Car>().SingleOrDefault(filter);
                    // db set car a bağlan
            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (RentACarContext context = new RentACarContext())
            {
                
                return filter == null ? 
                    context.Set<Car>().ToList()
                    : context.Set<Car>().Where(filter).ToList();

                    //selecet * from product -- listeye çevir
                    // eğer filtre verilmiş ise filtrele listeye çevir
            }
        }

        public void Update(Car entity)
        {
            using (RentACarContext context = new RentACarContext()) // performans 
            {
                var updatedEntity = context.Entry(entity); // verilen nesneye eriş
                updatedEntity.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                // erişilen nesneyi ekle
                context.SaveChanges();
            }
        }
    }
}
