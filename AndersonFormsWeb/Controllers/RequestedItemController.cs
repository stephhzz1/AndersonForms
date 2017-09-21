
using System;
using System.Web.Mvc;
using System.Linq;
using AndersonFormsFunction;
using AndersonFormsModel;

namespace AndersonFormsWeb.Controllers
{

    [RoutePrefix("RequestedItem")]
    public class RequestedItemController : Controller
    {
        private IFRequestedItem _iFRequestedItem;

        public RequestedItemController()
        {
            _iFRequestedItem = new FRequestedItem();
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

        public JsonResult Create(RequestedItem requestedItem)
        {

            try
            {
                requestedItem = _iFRequestedItem.Create(requestedItem);
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