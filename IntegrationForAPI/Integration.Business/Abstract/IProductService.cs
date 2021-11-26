using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Integration.Core.Utilities.Result;
using Integration.Entities.Concrete.DataBase;

namespace Integration.Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll();
        IResult Add(Product product);
    }
}
