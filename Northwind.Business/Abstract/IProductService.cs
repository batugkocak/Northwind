using Northwind.Business.Utilities.Results;
using Northwind.Entities.Concrete;
using Northwind.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.Abstract
{
    public interface IProductService
    {
       
        //IDataResult<List<Product>> GetAllByCategoryId(int id);
        //IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max);

        IDataResult<List<ProductDetailDto>> GetProductDetails();
        IDataResult<List<Product>> GetAll();
        IDataResult<Product> GetById(int productId);
        IDataResult<ProductDetailDto> GetDetailsById(int productId);
        IResult Add(Product product);
        IResult Update(Product product);
    }
}
