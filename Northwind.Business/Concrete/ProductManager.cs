using Northwind.Business.Abstract;
using Northwind.Business.Constants;
using Northwind.Business.Utilities.Results;
using Northwind.DataAccess.Abstract;
using Northwind.Entities.Concrete;
using Northwind.Entities.DTOs;

namespace Northwind.Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
     

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public IResult Add(Product product)
        {
             _productDal.Add(product);

            return new SuccessResult(Messages.Added);
        }

        public IDataResult<List<Product>> GetAll()
        {
            Random rnd = new Random();
            if (rnd.Next(2) == 1)
            {
                return new ErrorDataResult<List<Product>>(Messages.MaintenanceTime);
            }

            return new SuccessDataResult<List<Product>>(_productDal.GetAll(), Messages.Listed);
        }

        public IDataResult<Product> GetById(int productId)
        {

            var result = _productDal.Get(p => p.ProductId == productId);
                
            return new SuccessDataResult<Product>(result, Messages.Listed);
        }

        public IDataResult<ProductDetailDto> GetDetailsById(int productId)
        {
            var result = _productDal.GetProductDetailsById(productId);
            if (result == null)
            {
                return new ErrorDataResult<ProductDetailDto>(Messages.NotFound);
            }
            return new SuccessDataResult<ProductDetailDto>(Messages.Listed);
        }

        public IDataResult<List<ProductDetailDto>> GetProductDetails()
        {
            var result = _productDal.GetProductDetails();

            return new SuccessDataResult<List<ProductDetailDto>>(result, Messages.Listed);
        }

        public IResult Update(Product product)
        {
             _productDal.Update(product);

            return new SuccessDataResult<Product>(product, Messages.Updated);
        }
    }
}
