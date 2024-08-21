using Northwind.Business.Abstract;
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

            return new SuccessResult( "Ürün eklendi.");
        }

        public IDataResult<List<Product>> GetAll()
        {
            Random rnd = new Random();
            if (rnd.Next(2) == 1)
            {
                return new ErrorDataResult<List<Product>>("Bakım var!");
            }

            return new SuccessDataResult<List<Product>>(_productDal.GetAll(), "Ürünler listelendi.");
        }

        public IDataResult<Product> GetById(int productId)
        {

            var result = _productDal.Get(p => p.ProductId == productId);
                
            return new SuccessDataResult<Product>(result, "Ürün bulundu.");
        }

        public IDataResult<ProductDetailDto> GetDetailsById(int productId)
        {
            var result = _productDal.GetProductDetailsById(productId);
            if (result == null)
            {
                return new ErrorDataResult<ProductDetailDto>("Bu ID'ye ait ürün bulunamadı.");
            }
            return new SuccessDataResult<ProductDetailDto>("Ürün bulundu.");
        }

        public IDataResult<List<ProductDetailDto>> GetProductDetails()
        {
            var result = _productDal.GetProductDetails();

            return new SuccessDataResult<List<ProductDetailDto>>(result, "Ürünler listelendi.");
        }

        public IResult Update(Product product)
        {
             _productDal.Update(product);

            return new SuccessDataResult<Product>(product, "Ürün güncellendi.");
        }
    }
}
