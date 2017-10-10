using AndersonFormsModel;
using System.Collections.Generic;

namespace AndersonFormsFunction
{

    public interface IFByod
    {
        #region Create
        Byod Create(Byod byod);
        #endregion

        #region Read
        Byod Read(int byodId);
        List<Byod> Read();
        List<Byod> ReadForApproval(int approverId);
        List<Byod> ReadRequested(int employeeId);
        #endregion

        #region Update
        Byod Update(Byod byod);
        void Approve(int approvedBy, int byodId);
        #endregion

        #region Delete
        void Delete(int byodId);
        #endregion

    }
}