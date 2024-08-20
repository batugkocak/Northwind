using Core.DataAccess;
using Northwind.Entities.Concrete;

namespace Northwind.DataAccess.Abstract
{
    public interface ICustomerDal : IEntityRepository<Customer>
    {


    }
}
