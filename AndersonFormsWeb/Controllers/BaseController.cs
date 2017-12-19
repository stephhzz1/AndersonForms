using AccountsFunction;
using AccountsModel;
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

        protected int EmployeeId
        {
            get
            {
                int UserId = CurrentUser?.EmployeeId ?? 0;
                return UserId;
            }
        }

        protected int UserId
        {
            get
            {
                int UserId = CurrentUser?.UserId ?? 0;
                return UserId;
            }
        }

        protected string Username
        {
            get
            {
                return WindowsUser.Username;
            }
        }

        protected User CurrentUser
        {
            get
            {
                var user = _iFUser.Read(Username);
                return user;
            }
        }
    }
}