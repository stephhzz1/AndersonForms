
using System;
using System.Web.Mvc;
using System.Linq;
using AndersonFormsFunction;
using AndersonFormsModel;
using AndersonFormsWeb.Models;
using AndersonCRMFunction;

namespace AndersonFormsWeb.Controllers
{

    [RoutePrefix("RequestedItem")]
    public class RequestedItemController : Controller
    {
        private IFRequestedItem _iFRequestedItem;
        private IFEmployee _iFEmployee;

        public RequestedItemController()
        {
            _iFRequestedItem = new FRequestedItem();
            _iFEmployee = new FEmployee();
        }

        [Route("")]
        [HttpGet]
        public ActionResult Index()
        {

            return View();
        }

        

        [HttpGet]
        public ActionResult Create()
        {
            return View(new RequestedItem());
        }

        [HttpPost]

        public JsonResult Create(int id ,RollInModel rollInModel)

        {

            try
            {


                var employee = _iFEmployee.Create(id, rollInModel.Employee);

                foreach (var requestedItem in rollInModel.RequestedItems)
                {
                    requestedItem.EmployeeId = employee.EmployeeId;
                    _iFRequestedItem.Create(requestedItem);
                }
                return Json("");
            }
            catch (Exception ex)
            {
                return Json(ex);
            }

        }
       

        [Route("List")]
        [HttpPost]
        public JsonResult List()
        {
            try
            {
                RequestedItem requestedItem = new RequestedItem();
                return Json(_iFRequestedItem.List());
            }
            catch (Exception exception)
            {
                return Json(exception);
            }
        }


    }
}