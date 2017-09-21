namespace AndersonFormsModel
{
    public class RequestedItem : Base.Base
    {
        public int EmployeeId { get; set; }
        public int DepartmentId { get; set; }
        public int ImplementedBy { get; set; }
        public int RemovedBy { get; set; }
        public int RequestedItemId { get; set; }

        public string Comment { get; set; }

    }
}

