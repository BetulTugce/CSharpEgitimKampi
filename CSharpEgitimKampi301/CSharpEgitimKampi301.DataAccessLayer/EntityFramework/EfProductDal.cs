using CSharpEgitimKampi301.DataAccessLayer.Abstract;
using CSharpEgitimKampi301.DataAccessLayer.Contexts;
using CSharpEgitimKampi301.DataAccessLayer.Repositories;
using CSharpEgitimKampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpEgitimKampi301.DataAccessLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        public List<Object> GetProductsWithCategory()
        {
            var context = new KampContext();
            var values = context.Products.Select(p => new
            {
                Id = p.ProductId,
                Name = p.Name,
                Price = p.Price,
                Stock = p.Stock,
                Category = p.Category.Name,
                Description = p.Description,
            }).ToList();
            return values.Cast<object>().ToList();
        }
    }
}
