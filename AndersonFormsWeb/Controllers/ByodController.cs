using AndersonCRMFunction;
using AndersonFormsFunction;
using AndersonFormsModel;
using System;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace AndersonFormsWeb.Controllers
{
    //[System.Web.Mvc.Accounts.CustomAuthorizeAttribute(UserRole = "Exam Manager")]
    public class ByodController : BaseController
    {
        private IFByod _iFByod;
        private IFEmployee _iFEmployee;


        public ByodController()
        {
            _iFByod = new FByod();
            _iFEmployee = new FEmployee();

        }

        #region Create
        [HttpGet]
        public ActionResult Create()
        {
            return View(new Byod());
        }

        [HttpPost]
        public ActionResult Create(Byod byod)
        {
            try
            {
                var account = CurrentUser;
                byod.EmployeeId = account.EmployeeId;
                byod.RequestedBy = account.UserId;
                byod.CreatedBy = account.UserId;
                if (account.EmployeeId != 0)
                {
                    var employee = _iFEmployee.Read(account.EmployeeId);
                    byod.ApproverId = employee.ManagerEmployeeId;
                }
                byod = _iFByod.Create(byod);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return Json(ex);
            }
        }
        #endregion

        #region Read
        [HttpGet]
        public ActionResult Index()
        {

            return View();
        }

        [HttpPost]
        public JsonResult Read()
        {
            return Json(_iFByod.Read());
        }

        [HttpPost]
        public JsonResult ReadForApproval()
        {
            return Json(_iFByod.ReadForApproval(EmployeeId));
        }

        [HttpPost]
        public JsonResult ReadRequested()
        {
            return Json(_iFByod.ReadRequested(EmployeeId));
        }

        //protected void Page_Load(object sender, EventArgs e)
        //{
        //    if (!this.IsPostBack)
        //    {
        //        this.BindGrid();
        //    }
        //}

        //private void BindGrid()
        //{
        //    string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
        //    using (SqlConnection con = new SqlConnection(constr))
        //    {
        //        using (SqlCommand cmd = new SqlCommand("SELECT CustomerId, ContactName, City, Country FROM Customers"))
        //        {
        //            using (SqlDataAdapter sda = new SqlDataAdapter())
        //            {
        //                cmd.Connection = con;
        //                sda.SelectCommand = cmd;
        //                using (DataTable dt = new DataTable())
        //                {
        //                    sda.Fill(dt);
        //                    GridView1.DataSource = dt;
        //                    GridView1.DataBind();
        //                }
        //            }
        //        }
        //    }
        //}


        #endregion

        #region Update
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

        [HttpPost]
        public JsonResult Approve(int id)
        {
            try
            {
                _iFByod.Approve(UserId, id);
                return Json(true);
            }
            catch (Exception ex)
            {
                return Json(false);
            }
        }
        #endregion

        #region Delete 
        [HttpDelete]
        public JsonResult Delete(int id)
        {
            try
            {
                _iFByod.Delete(id);
                return Json(true);
            }
            catch (Exception ex)
            {
                return Json(false);
            }
        }
        #endregion

        #region Other
        #endregion
    }
}