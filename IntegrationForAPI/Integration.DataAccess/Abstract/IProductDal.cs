using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Integration.Core.DataAccess;
using Integration.Entities.Concrete.DataBase;
using Integration.Entities.Concrete.TSoft;

namespace Integration.DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
    }
}