using Northwind.Business.Abstract;
using Northwind.Business.Utilities.Results;
using Northwind.DataAccess.Abstract;
using Northwind.Entities.Concrete;

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

        public IResult Update(Product product)
        {
             _productDal.Update(product);

            return new SuccessDataResult<Product>(product, "Ürün güncellendi.");
        }
    }
}
