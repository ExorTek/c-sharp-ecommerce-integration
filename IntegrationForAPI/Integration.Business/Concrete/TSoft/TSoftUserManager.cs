using System;
using System.Threading.Tasks;
using Integration.Business.Abstract.TSoft;
using Integration.Core.Utilities.Result;
using Integration.DataAccess.Abstract.TSoft;
using Integration.Entities.Concrete.TSoft;
using Quartz;

namespace Integration.Business.Concrete.TSoft
{
    public class TSoftUserManager : ITSoftUserService
    {
        private ITSoftUserDal _tSoftUserDal;

        public TSoftUserManager(ITSoftUserDal tSoftUserDal)
        {
            _tSoftUserDal = tSoftUserDal;
        }

        public TSoftUser Login()
        {
            return _tSoftUserDal.Login();
        }
    }
}