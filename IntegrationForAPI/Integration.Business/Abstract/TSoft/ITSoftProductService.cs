using System.Collections.Generic;
using Integration.Core.Utilities.Result;
using Integration.Entities.Concrete.TSoft;

namespace Integration.Business.Abstract.TSoft
{
    public interface ITSoftProductService
    {
        TSoftProduct GetAll(int start);
    }
}