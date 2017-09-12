using AccountsWebAuthentication.Helper;
using AndersonFormsFunction;
using AndersonFormsModel;
using System;
using System.Web.Mvc;

namespace AndersonFormsWeb.Controllers
{
    [CustomAuthorizeAttribute(AllowedRoles =  new string[0])]
    public class ByodController : BaseController
    {
        private IFByod _iFByod;

        public ByodController()
        {
            _iFByod = new FByod();
        }

        #region Get: Byod
        public ActionResult Index()
        {
            return View();
        }
        #endregion

        #region HttpPost List
        [HttpPost]
        public ActionResult List()
        {
            try
            {
                return Json(_iFByod.Read());
            }
            catch (Exception ex)
            {
                return Json(ex);
            }
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
            try
            {
                byod.RequestedBy = UserID;
                byod = _iFByod.Create(byod);
                return RedirectToAction("Index", "Byod");
            }
            catch (Exception ex)
            {
                return Json(byod);
            }
        }
        #endregion

        #region HttpPost Add (old)
        //[HttpPost]
        //public ActionResult Add(Byod byod)
        //{
        //    byod = _iFByod.Create(byod);
        //    return View(byod);
        //}
        #endregion

        #region HttpGet Update
        [HttpGet]
        public ActionResult Update(int id)
        {
            try
            {
                Byod byod = _iFByod.Read(id);
                return View(byod);
            }
            catch (Exception ex)
            {
                return View(new Byod());
            }
        }
        #endregion

        #region HttpPost Update
        [HttpPost]
        public ActionResult Update(Byod byod)
        {
            try
            {
                byod = _iFByod.Update(byod);
                return RedirectToAction("Index", "Byod");
            }
            catch (Exception ex)
            {
                return View(byod);
            }
        }
        #endregion

        #region HttpGet Edit
        [HttpGet]
        public ActionResult Edit()
        {
            return View(new Byod());
        }
        #endregion
    
        #region HttpPost Delete
        [HttpPost]
        public ActionResult Delete(Byod byod)
        {
            try
            {
                _iFByod.Delete(byod);
                return Json("");
            }
            catch (Exception ex)
            {
                return Json(ex);
            }
        }
        #endregion
        #region AboutUs
        public ActionResult AboutUs()
        {
            ViewBag.Message = "B.Y.O.D (Bring Your Own Device)";

            return View();
        }
        #endregion
    }
}