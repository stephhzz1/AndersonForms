using AndersonFormsModel;
using System.Collections.Generic;


namespace AndersonFormsFunction
{
    public interface IFRequestedItem
    {
        #region CREATE
        RequestedItem Create(RequestedItem requestedItem);
        #endregion
        #region READ
        RequestedItem Read(int EmployeeId);
        List<RequestedItem> List();

        #endregion

    }
}
