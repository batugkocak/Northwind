using Core.DataAccess.EntityFramework;
using Northwind.Business.Abstract;
using Northwind.Business.Utilities.Results;
using Northwind.DataAccess.Abstract;
using Northwind.Entities.Concrete;

namespace Northwind.Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        ICategoryService _categoryService;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public IResult Add(Product product)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Product>> GetAll()
        {
            Random rnd = new Random();
            if (rnd.Next(1) == 1)
            {
                return new ErrorDataResult<List<Product>>("Bakım var!");
            }

            return new SuccessDataResult<List<Product>>(_productDal.GetAll(), "Ürünler listelendi.");
        }

        public IDataResult<Product> GetById(int productId)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
