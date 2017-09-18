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
        List<Byod> ReadForApproval(int approverId);
        List<Byod> Read();
        //List<Byod> ReadForByod();
        #endregion

        #region Update
        Byod Update(Byod byod);
        #endregion

        #region Approve
        Byod Approve(Byod byod);
        #endregion

        #region Delete
        void Delete(Byod byod);
        #endregion

    }
}