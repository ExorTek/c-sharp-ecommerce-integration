using Integration.Core.Utilities.Result;
using Integration.Entities.Concrete.TSoft;

namespace Integration.Business.Abstract.TSoft
{
    public interface ITSoftUserService
    {
        TSoftUser Login();
    }
}