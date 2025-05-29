using Bogus;
using HepsiApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiApi.Persistance.Configurations
{
    public class ProductConfiguraiton : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            Faker faker = new("tr");

            Product product1 = new()
            {
                Id = 1,
                Title = faker.Commerce.ProductName(),
                Description = faker.Commerce.ProductDescription(),
                BranId = 1,
                Discount = faker.Random.Decimal(0, 10),
                Price = faker.Finance.Amount(10, 10000),
                IsDeleted=false,
                CreateDate=DateTime.Now
            };
            Product product2 = new()
            {
                Id = 2,
                Title = faker.Commerce.ProductName(),
                Description = faker.Commerce.ProductDescription(),
                BranId = 3,
                Discount = faker.Random.Decimal(0, 10),
                Price = faker.Finance.Amount(10, 10000),
                IsDeleted = false,
                CreateDate = DateTime.Now
            };

            builder.HasData(product1, product2);
        }
    }
}
