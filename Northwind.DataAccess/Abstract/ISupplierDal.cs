using Core.DataAccess;
using Northwind.Entities.Concrete;

namespace Northwind.DataAccess.Abstract
{
    public interface ISupplierDal : IEntityRepository<Supplier>
    {
        //List<ProductDetailDto> GetProductDetails();
        //ProductDetailDto GetProductDetailsById(int id);
    }
}
