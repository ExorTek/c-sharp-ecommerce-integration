using Integration.Core.Utilities.Result;
using Integration.Entities.Concrete.TSoft;

namespace Integration.DataAccess.Abstract.TSoft
{
    public interface ITSoftUserDal 
    {
        TSoftUser Login();
    }
}