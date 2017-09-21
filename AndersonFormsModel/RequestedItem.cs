using Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndersonFormsModel
{
        public class RequestedItem : Base.Base
    {
       [System.ComponentModel.DataAnnotations.Required]
        
        public int EmployeeId { get; set; }
        public int DepartmentId { get; set; }
        public int RequestedItemId { get; set; }

        public string RemovedBy { get; set; }
        public string ImplementedBy { get; set; }
        public string Comment { get; set; }

        }
    }

