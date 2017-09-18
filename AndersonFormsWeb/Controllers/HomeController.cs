using System.Web.Mvc;
using AccountsFunction;
using AndersonCRMFunction;
using AndersonFormsFunction;
using AndersonFormsModel;
using System;

namespace AndersonFormsWeb.Controllers
{
    public class HomeController : Controller
    {
        
        #region Get: Home

        public ActionResult Index()
        {
            return View();
        }
        #endregion
  
    }

}