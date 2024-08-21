using Core.DataAccess.EntityFramework;
using Northwind.DataAccess.Abstract;
using Northwind.Entities.Concrete;
using Northwind.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {
        public List<ProductDetailDto> GetProductDetails()
        {
            using NorthwindContext context = new NorthwindContext();
            IQueryable<ProductDetailDto> result = GetDetailedProducts(context);

            return result.ToList();

        }


        public ProductDetailDto GetProductDetailsById(int id)
        {
            using NorthwindContext context = new NorthwindContext();
            IQueryable<ProductDetailDto> result = GetDetailedProducts(context).Where(p => p.ProductId == id);

            return result.SingleOrDefault();
        }

        private static IQueryable<ProductDetailDto> GetDetailedProducts(NorthwindContext context)
        {
            return from p in context.Products
                   join c in context.Categories
                   on p.CategoryId equals c.CategoryId
                   join s in context.Suppliers
                   on p.SupplierId equals s.SupplierID
                   select new ProductDetailDto
                   {
                       ProductId = p.ProductId,
                       ProductName = p.ProductName,
                       CategoryName = c.CategoryName,
                       SupplierName = s.CompanyName,
                       SupplierCountry = s.Country,
                       UnitPrice = p.UnitPrice,
                       UnitsInStock = p.UnitsInStock
                   };
        }
    }
}
