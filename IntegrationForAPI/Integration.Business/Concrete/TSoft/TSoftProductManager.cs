using System.Collections.Generic;
using Integration.Business.Abstract.TSoft;
using Integration.Business.Constants;
using Integration.Core.Utilities.Result;
using Integration.DataAccess.Abstract.TSoft;
using Integration.Entities.Concrete.TSoft;

namespace Integration.Business.Concrete.TSoft
{
    public class TSoftProductManager : ITSoftProductService
    {
        private ITSoftProductDal _tSoftProductDal;

        public TSoftProductManager(ITSoftProductDal tSoftProductDal)
        {
            _tSoftProductDal = tSoftProductDal;
        }


        public TSoftProduct GetAll(int start)
        {
            return _tSoftProductDal.GetAll(start);
        }
    }
}