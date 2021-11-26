
using TSoft.Business.Abstract.TSoft;
using TSoft.DataAccess.Abstract.TSoft;
using TSoft.Entities.Concrete.TSoft;

namespace TSoft.Business.Concrete.TSoft
{
    public class ProductManager :IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }


        public Product GetAll()
        {
            return _productDal.GetAll();
        }
    }
}