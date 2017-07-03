using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DZ3
{
    public class ProductRepository : IRepository<Product>
    {
        private MyContext _context;

        public ProductRepository(MyContext context)
        {
            _context = context;
        }

        public void Create(Product entity)
        {
            _context.Products.Add(entity);
            _context.SaveChanges();
        }
        public void Delete(Product entity)
        {
            _context.Products.Remove(entity);
            _context.SaveChanges();
        }
        public IQueryable<Product> GetAll()
        {
            return _context.Products;
        }
        public void Update(Product entity)
        {
            Product user = _context.Products.Find(entity.Id);
            user = entity;
            _context.SaveChanges();
        }
    }
}