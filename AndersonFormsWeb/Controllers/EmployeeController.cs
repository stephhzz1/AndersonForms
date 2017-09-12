using AndersonCRMModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Collections;

namespace AndersonFormsWeb.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeContext Mcon = new EmployeeContext();
  
        public ActionResult Index()
        {
            Employee MD = new Employee();
            MD.EmployeeList = new SelectList(Mcon.GetEmployeeList(), "EmployeeId");
            return View(MD);
        }

        private class EmployeeContext
        {
            internal IEnumerable GetEmployeeList()
            {
                throw new NotImplementedException();
            }
        }
    }
}