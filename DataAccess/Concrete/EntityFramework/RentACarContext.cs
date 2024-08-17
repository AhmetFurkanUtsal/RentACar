using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{

    // db tabloları ile prje classlarını bağlama
    public class RentACarContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=RentACarDb;Trusted_Connection=True;");


        }
        // class tablo bağlantısı
        public DbSet<Car> Cars { get; set; }


        public DbSet<Brand> Brands { get; set; }

        public DbSet<Color> Colors { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brand>().HasData(
                new Brand { BrandId = 1, BrandName = "Toyota" },
                new Brand { BrandId = 2, BrandName = "Ford" },
                new Brand { BrandId = 3, BrandName = "Bmw"}
            );

            modelBuilder.Entity<Color>().HasData(
                new Color { ColorId = 1, ColorName = "Red" },
                new Color { ColorId = 2, ColorName = "Blue" },
                new Color { ColorId = 3, ColorName = "Pink"}
            );

            modelBuilder.Entity<Car>().HasData(
                new Car { CarId = 1, BrandId = 1, ColorId = 1, ModelYear = 2022, DailyPrice = 500, Description = "Ortadoğu içn özel tasarım" },
                new Car { CarId = 2, BrandId = 2, ColorId = 2, ModelYear = 2023, DailyPrice = 1500, Description = "Alırsın Ford olursun lord" },
                new Car { CarId = 3, BrandId = 3, ColorId = 3, ModelYear = 2022, DailyPrice = 1222, Description= "sinyal kullanmayanlar için"}
            );
        }

    }


}
