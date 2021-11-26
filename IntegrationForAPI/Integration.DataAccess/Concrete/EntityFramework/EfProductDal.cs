using System.Collections.Generic;
using System.Linq;
using Integration.Core.DataAccess;
using Integration.Core.DataAccess.EntityFramework;
using Integration.DataAccess.Abstract;
using Integration.Entities.Concrete.DataBase;
using Integration.Entities.Concrete.TSoft;
using Microsoft.EntityFrameworkCore;

namespace Integration.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product,IntegrationContext>,IProductDal
    {
        
    }
}