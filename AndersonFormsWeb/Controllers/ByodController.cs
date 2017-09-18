using AccountsFunction;
using AndersonCRMFunction;
using AndersonFormsFunction;
using AndersonFormsModel;
using System;
using System.Web.Mvc;

namespace AndersonFormsWeb.Controllers
{
    //[System.Web.Mvc.Accounts.CustomAuthorizeAttribute(UserRole = "Exam Manager")]
    public class ByodController : BaseController
    {
        private IFByod _iFByod;
        private IFUser _iFUser;
        private IFEmployee _iFEmployee;


        public ByodController()
        {
            _iFByod = new FByod();
            _iFUser = new FUser();
            _iFEmployee = new FEmployee();

        }

        #region Get: Byod
        public ActionResult Index()
        {
            return View();
        }
        #endregion

        #region Approval
        public ActionResult Approval()
        {
            return View();
        }
        #endregion

        #region Request
        public ActionResult Request()
        {
            return View();
        }
        #endregion

        #region List2
        [HttpPost]
        public ActionResult List2()

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


        #region HttpPost List
        [HttpPost]
        public ActionResult List()
        {
            try
            {
                var user = _iFUser.ReadUser(Username);
                return Json(_iFByod.ReadForApproval(user.EmployeeId));
                //var employee = _iFEmployee.ReadEmployee(Employee);
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
                byod = _iFByod.Create(byod);
                return RedirectToAction("Index", "Byod");
            }
            catch (Exception ex)
            {
                return Json(byod);
            }
        }
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

        //    #region HttpGet Approve
        //    [HttpGet]
        //    public ActionResult Approve(int id)
        //    { var user = _iFUser.ReadUser(Username);
        //        return Json(_iFByod.ReadForApproval(user.EmployeeId));
        //        { 
        //        try

        //        {

        //            Byod byod = _iFByod.Read(id);
        //            return View(byod);
        //        }
        //        catch (Exception ex)
        //        {
        //            return View(new Byod());
        //        }
        //    }
        //}
        //#endregion   [HttpPost, ActionName("ClockIn")]
   
        #region HttpPost Approve
        [HttpPost]
        public ActionResult Approve(Byod byod)
        {
            try
            {
                byod = _iFByod.Approve(byod);
                return RedirectToAction( "Byod");
            }
            catch (Exception ex)
            {
                return View(byod);
            }
        }
        #endregion

    }
}