using TSoft.DataAccess.Abstract.TSoft;
using TSoft.Entities.Concrete.TSoft;

namespace TSoft.Business.Concrete.TSoft
{
    public class UserManager 
    {
         IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public User Login()
        {
            return _userDal.Login();
        }
    }
}