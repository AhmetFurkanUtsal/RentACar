using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity,TContext> 
        where TEntity : class,IEntity, new()
        where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            using (TContext context = new TContext()) // performans 
            {
                var addedEntity = context.Entry(entity); // verilen nesneye eriş
                addedEntity.State = Microsoft.EntityFrameworkCore.EntityState.Added;
                // erişilen nesneyi ekle
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext()) // performans 
            {
                var deletedEntity = context.Entry(entity); // verilen nesneye eriş
                deletedEntity.State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                // erişilen nesneyi ekle
                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
                // db set car a bağlan
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {

                return filter == null ?
                context.Set<TEntity>().ToList()
                : context.Set<TEntity>().Where(filter).ToList();

                //selecet * from product -- listeye çevir
                // eğer filtre verilmiş ise filtrele listeye çevir
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext()) // performans 
            {
                var updatedEntity = context.Entry(entity); // verilen nesneye eriş
                updatedEntity.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                // erişilen nesneyi ekle
                context.SaveChanges();
            }
        }
    }
}
