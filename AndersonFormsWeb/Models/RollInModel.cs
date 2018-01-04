using AndersonCRMModel;
using AndersonFormsModel;
using System.Collections.Generic;

namespace AndersonFormsWeb.Models
{
    public class RollInModel
    { 
        public Employee Employee { get; set; }

        public List<RequestedItem> RequestedItems { get; set; }
    }
}