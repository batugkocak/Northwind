using Core.DataAccess;
using Northwind.Entities.Concrete;

namespace Northwind.DataAccess.Abstract
{
    public interface IOrderDal : IEntityRepository<Order>
    {
    }
}
