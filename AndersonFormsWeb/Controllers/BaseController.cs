using AccountsFunction;
using AccountsWebAuthentication.Helper;
using System.Web.Mvc;

namespace AndersonFormsWeb.Controllers
{
    public class BaseController : Controller
    {
        private IFUser _iFUser;

        public BaseController()
        {
            _iFUser = new FUser();
        }

        protected string Username
        {
            get
            {
                return WindowsUser.Username;
            }
        }

        protected int UserID
        {
            get
            {
                var user = _iFUser.ReadUser(Username);
                int UserID = user?.UserID ?? 0;
                return UserID;
            }
        }
    }
}