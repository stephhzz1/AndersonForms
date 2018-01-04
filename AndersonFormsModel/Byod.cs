using System;



namespace AndersonFormsModel
{
    public class Byod : Base.Base
    {
        public bool Approved
        {
            get
            {
                return ApprovedBy != 0;
            }
        }

        public DateTime? ApprovedDate { get; set; }
      


        public int ApprovedBy { get; set; }
        public int ApproverId { get; set; }
        public int ByodId { get; set; }
        public int EmployeeId { get; set; }
        public int RequestedBy { get; set; }
        public int TypeOfDeviceId { get; set; }

        public string BrandName { get; set; }
        public string ContactNo { get; set; }
        public string Email { get; set; }
        public string SerialNumber { get; set; }



    }
}
