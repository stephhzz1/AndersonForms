using AccountsFunction;
using AndersonCRMFunction;
using AccountsEntity;
using AccountsModel;
using AndersonFormsData;
using AndersonFormsEntity;
using AndersonFormsModel;
using System.Collections.Generic;
using System.Linq;

namespace AndersonFormsFunction
{
     public class FByod: IFByod
     {
        private IDByod _iDByod;
        private IFUser _iFUser;
        private IFEmployee _iFEmployee;

        public FByod()
        {
            _iDByod = new DByod();
            _iFUser = new FUser();
        }

        #region Create
        public Byod Create(Byod byod)
        {
            EByod eByod = EByod(byod);
            eByod = _iDByod.Create(eByod);
            //var account = _iFUser.ReadUser(Username);
            return Byod(eByod);
        }
        #endregion

        #region Read
        public List<Byod> Read()
        {
            List<EByod> eByods = _iDByod.Read<EByod>(a => true, "ByodId");
            return Byods(eByods);
        }

        #region ReadList2
        public List<Byod> Read2()
        {
            List<EByod> eByods = _iDByod.Read<EByod>(a => true, "ByodId");
            return Byods(eByods);
        }
        #endregion

        public List<Byod> ReadForApproval(int approverId)
        {
            List<EByod> eByods = _iDByod.Read<EByod>(a => a.ApproverId == approverId, "ByodId");
            eByods = eByods.OrderByDescending(a => a.ByodId).ToList();
            return Byods(eByods);
        }

      

        public Byod Read(int byodId)
        {
            EByod eByod = _iDByod.Read<EByod>(a => a.ByodId == byodId);
            return Byod(eByod);
        }
        #endregion

        #region Update
        public Byod Update(Byod byod)
        {
            
            EByod eByod = EByod(byod);
            eByod = _iDByod.Update(eByod);
            return Byod(eByod);
        }
        #endregion

        #region Approve
        public Byod Approve(Byod byod)
        {
            EByod eByod = EByod(byod);
            eByod = _iDByod.Approve(eByod);
            return Byod(eByod);
        }
        #endregion

        #region Delete
        public void Delete(Byod byod)
        {
            EByod eByod = EByod(byod);
            _iDByod.Delete(eByod);
        }
        #endregion


        #region Other Function
        private EByod EByod(Byod byod)
        {
            return new EByod
            {
                ApprovedBy = byod.ApprovedBy,
                ApproverId = byod.ApproverId,
                ByodId = byod.ByodId,
                EmployeeId = byod.EmployeeId,
                RequestedBy = byod.RequestedBy,
                TypeOfDeviceId = byod.TypeOfDeviceId,
                BrandName = byod.BrandName,
                ContactNo = byod.ContactNo,
                Email = byod.Email,
                SerialNumber = byod.SerialNumber,
            };
        }

        private Byod Byod(EByod eByod)
        {
            return new Byod
            {
                ApprovedBy = eByod.ApprovedBy,
                ApproverId = eByod.ApproverId,
                ByodId = eByod.ByodId,
                EmployeeId = eByod.EmployeeId,
                RequestedBy = eByod.RequestedBy,
                TypeOfDeviceId = eByod.TypeOfDeviceId,
                BrandName = eByod.BrandName,
                ContactNo = eByod.ContactNo,
                Email = eByod.Email,
                SerialNumber = eByod.SerialNumber,
            };
        }

        private List<Byod> Byods(List<EByod> eByods)
        {
            return eByods.Select(a =>
                new Byod
                {
                    ApprovedBy = a.ApprovedBy,
                    ApproverId = a.ApproverId,
                    ByodId = a.ByodId,
                    EmployeeId = a.EmployeeId,
                    RequestedBy = a.RequestedBy,
                    TypeOfDeviceId = a.TypeOfDeviceId,
                    BrandName = a.BrandName,
                    ContactNo = a.ContactNo,
                    Email = a.Email,
                    SerialNumber = a.SerialNumber,
                }
                ).ToList();
        }

        //private List2<Byod> Byods(List2<EByod> eByods)
        //{
        //    return eByods.Select(a =>
        //        new Byod
        //        {
        //            ApprovedBy = a.ApprovedBy,
        //            ApproverId = a.ApproverId,
        //            ByodId = a.ByodId,
        //            EmployeeId = a.EmployeeId,
        //            RequestedBy = a.RequestedBy,
        //            TypeOfDeviceId = a.TypeOfDeviceId,
        //            BrandName = a.BrandName,
        //            ContactNo = a.ContactNo,
        //            Email = a.Email,
        //            SerialNumber = a.SerialNumber,
        //        }
        //        ).ToList();
        //}
        #endregion
    }
}