using Core.DataAccess;
using Northwind.Entities.Concrete;
using Northwind.Entities.DTOs;

namespace Northwind.DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
        List<ProductDetailDto> GetProductDetails();
        ProductDetailDto GetProductDetailsById(int id);
    }
}
