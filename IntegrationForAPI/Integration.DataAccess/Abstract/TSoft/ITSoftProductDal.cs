using System.Collections.Generic;
using Integration.Entities.Concrete.TSoft;

namespace Integration.DataAccess.Abstract.TSoft
{
    public interface ITSoftProductDal
    {
        TSoftProduct GetAll(int start);
    }
}