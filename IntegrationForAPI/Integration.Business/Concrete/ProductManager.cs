using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Integration.Business.Abstract;
using Integration.Business.Constants;
using Integration.Core.Utilities.Result;
using Integration.DataAccess.Abstract;
using Integration.Entities.Concrete.DataBase;

namespace Integration.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public IDataResult<List<Product>> GetAll()
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(), Messages.SuccessGetAllProduct);
        }

        public IResult Add(Product product)
        {
            _productDal.Add(product);
            return new SuccessResult(Messages.AddedProduct);
        }
    }
}