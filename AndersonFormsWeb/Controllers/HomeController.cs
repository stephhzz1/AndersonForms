using AndersonFormsFunction;
using AndersonFormsModel;
using System;
using System.Web.Mvc;

namespace AndersonFormsWeb.Controllers
{
    public class HomeController : BaseController
    {
        private IFByod _iFByod;

        public HomeController()
        {
            _iFByod = new FByod();
        }

        #region Get: Home
        public ActionResult Index()
        {
            return View();
        }
        #endregion

        #region HttpGet Add
        [HttpGet]
        public ActionResult Add()
        {            
            return View(new Byod());
        }
        #endregion 

        #region HttpPost Add
        [HttpPost]
        public ActionResult Add(Byod byod)
        {
            byod.RequestedBy = UserID;
            byod = _iFByod.Create(byod);
            return View(byod);
        }
        #endregion

        #region HttpPost List
        [HttpPost]
        public ActionResult List()
        {
            return Json(_iFByod.Read());
        }
        #endregion

        #region ActionResult Update
        public ActionResult Update(Byod byod)
        {
            try
            {
                byod = _iFByod.Update(byod);
                return View(byod);
            }
            catch(Exception ex)
            {
                return View(byod);
            }
        }
        #endregion

        #region AboutUs
        public ActionResult AboutUs()
        {
            return View();
        }
        #endregion

    }
}