using AndersonFormsData;
using AndersonFormsEntity;
using AndersonFormsModel;
using System.Collections.Generic;
using System.Linq;

namespace AndersonFormsFunction
{
    public class FRequestedItem : IFRequestedItem
    {
        private IDRequestedItem _iDRequestedItem;


        public FRequestedItem()
        {
            _iDRequestedItem = new DRequestedItem();
        }

        #region CREATE
        public RequestedItem Create(RequestedItem requestedItem)
        {
            ERequestedItem eRequestedItem = ERequestedItem(requestedItem);
            eRequestedItem = _iDRequestedItem.Create(eRequestedItem);
            return (RequestedItem(eRequestedItem));
        }
        #endregion

        #region READ
        public RequestedItem Read(int EmployeeId)
        {
            ERequestedItem eRequestedItem = _iDRequestedItem.Read<ERequestedItem>(a => a.EmployeeId == EmployeeId);
            return RequestedItem(eRequestedItem);
        }

        #endregion

        public List<RequestedItem> List()
        {
            List<ERequestedItem> eRequestedItems = _iDRequestedItem.List<ERequestedItem>(a => true);
            return RequestedItems(eRequestedItems);
        }



        private List<RequestedItem> RequestedItems(List<ERequestedItem> eRequestedItems)
        {
            var returnRequestedItems = eRequestedItems.Select(a => new RequestedItem
            {

                RequestedItemId = a.RequestedItemId,
                EmployeeId = a.EmployeeId,
                DepartmentId = a.DepartmentId,
                ImplementedBy = a.ImplementedBy,
                RemovedBy = a.RemovedBy,
                Comment = a.Comment
            });

            return returnRequestedItems.ToList();
        }

        private ERequestedItem ERequestedItem(RequestedItem requestedItem)
        {
            ERequestedItem returnERequestedItem = new ERequestedItem
            {
                RequestedItemId = requestedItem.RequestedItemId,
                EmployeeId = requestedItem.EmployeeId,
                DepartmentId = requestedItem.DepartmentId,
                ImplementedBy = requestedItem.ImplementedBy,
                RemovedBy = requestedItem.RemovedBy,
                Comment = requestedItem.Comment
            };
            return returnERequestedItem;
        }

        private RequestedItem RequestedItem(ERequestedItem eRequestedItem)
        {
            RequestedItem returnRequestedItem = new RequestedItem
            {
                RequestedItemId = eRequestedItem.RequestedItemId,
                EmployeeId = eRequestedItem.EmployeeId,
                DepartmentId = eRequestedItem.DepartmentId,
                ImplementedBy = eRequestedItem.ImplementedBy,
                RemovedBy = eRequestedItem.RemovedBy,
                Comment = eRequestedItem.Comment
            };
            return returnRequestedItem;
        }
    }
}
