using AndersonFormsData;
using AndersonFormsEntity;
using AndersonFormsModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AndersonFormsFunction
{
     public class FByod: IFByod
     {
        private IDByod _iDByod;

        public FByod()
        {
            _iDByod = new DByod();
        }

        #region Create
        public Byod Create(Byod byod)
        {
            EByod eByod = EByod(byod);
            eByod.CreatedDate = DateTime.Now;
            eByod = _iDByod.Create(eByod);
            return Byod(eByod);
        }
        #endregion

        #region Read
        public Byod Read(int byodId)
        {
            EByod eByod = _iDByod.Read<EByod>(a => a.ByodId == byodId);
            return Byod(eByod);
        }

        public List<Byod> Read()
        {
            List<EByod> eByods = _iDByod.Read<EByod>(a => true, "ByodId");
            return Byods(eByods);
        }

        public List<Byod> ReadForApproval(int approverId)
        {
            List<EByod> eByods = _iDByod.Read<EByod>(a => a.ApproverId == approverId, "ByodId");
            eByods = eByods.OrderByDescending(a => a.ByodId).ToList();
            return Byods(eByods);
        }

        public List<Byod> ReadRequested(int employeeId)
        {
            List<EByod> eByods = _iDByod.Read<EByod>(a => a.EmployeeId == employeeId, "ByodId");
            eByods = eByods.OrderByDescending(a => a.ByodId).ToList();
            return Byods(eByods);
        }
        #endregion

        #region Update
        public Byod Update(Byod byod)
        {
            EByod eByod = EByod(byod);
            eByod.UpdatedDate = DateTime.Now;
            eByod = _iDByod.Update(eByod);
            return Byod(eByod);
        }

        public void Approve(int approvedBy, int byodId)
        {
            EByod eByod = _iDByod.Read<EByod>(a => a.ByodId == byodId);
            eByod.UpdatedDate = DateTime.Now;
            eByod.UpdatedBy = approvedBy;
            
            eByod.ApprovedDate = DateTime.Now;
            eByod.ApprovedBy = approvedBy;
            _iDByod.Update(eByod);
        }
        #endregion

        #region Delete
        public void Delete(int byodId)
        {
            _iDByod.Delete<EByod>(a => a.ByodId == byodId);
        }
        #endregion

        #region Other Function
        private EByod EByod(Byod byod)
        {
            return new EByod
            {
                ApprovedDate = byod.ApprovedDate,
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
                ApprovedDate = eByod.ApprovedDate,
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
                    ApprovedDate = a.ApprovedDate,
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
        #endregion
    }
}