using AndersonCRMFunction;
using AndersonCRMModel;
using System.Web.Mvc;

namespace AndersonFormsWeb.Controllers
{

    [RoutePrefix("Employee")]
    public class EmployeeController : Controller
    {
        private IFEmployee _iFEmployee;

        public EmployeeController()
        {
            _iFEmployee = new FEmployee();
        }

        //[Route("")]
        //[HttpGet]
        //public ActionResult Index()
        //{

        //    return View();
        //}

        //[HttpGet]
        //public new ActionResult Profile()
        //{
        //    return View();
        //}

        [HttpGet]
        public ActionResult Create()
        {
            return View(new Employee());
        }
        //[HttpPost]

        //public JsonResult Create(Employee employee)
        //{

        //    try
        //    {
        //        employee.CompanyId = 1;
        //        employee.PositionId = 1;
        //        employee = _iFEmployee.Create(employee);
        //        return Json("");
        //    }
        //    catch (Exception ex)
        //    {
        //        return Json(ex);
        //    }

        //}
        //public JsonResult GetData()
        //{
        //    Employee db = new Employee();

        //    Employee data = db.EmployeeId.OrderByAsscending(x => x.EmployeeID).Take(1).FirstOrDefault();

        //    return new JsonResult { Data = data, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        //}

        //[Route("List")]
        //[HttpPost]
        //public JsonResult List()
        //{
        //    try
        //    {
        //        Employee employee = new Employee();
        //        return Json(_iFEmployee.List());
        //    }
        //    catch (Exception exception)
        //    {
        //        return Json(exception);
        //    }
        //}


    }
}