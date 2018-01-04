using AndersonFormsData;
using AndersonFormsEntity;
using AndersonFormsModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AndersonFormsFunction
{
    //public class FEmployee : IFEmployee
    //{
    //    private IDEmployee _iDEmployee;

    //    public FEmployee()
    //    {
    //        _iDEmployee = new DEmployee();
    //    }

    //    #region Create
    //    public Employee Create(Employee employee)
    //    {
    //        EEmployee eEmployee = EEmployee(employee);
    //        eEmployee.CreatedDate = DateTime.Now;
    //        eEmployee = _iDEmployee.Create(eEmployee);
    //        return Employee(eEmployee);
    //    }
    //    #endregion

    //    #region Read
    //    public Employee Read(int employeeId)
    //    {
    //        EEmployee eEmployee = _iDEmployee.Read<EEmployee>(a => a.EmployeeId == employeeId);
    //        return Employee(eEmployee);
    //    }

    //    public List<Employee> Read()
    //    {
    //        List<EEmployee> eEmployees = _iDEmployee.Read<EEmployee>(a => true, "EmployeeId");
    //        return Employees(eEmployees);
    //    }

    //    public List<Employee> ReadForApproval(int approverId)
    //    {
    //        List<EEmployee> eEmployees = _iDEmployee.Read<EEmployee>(a => a.ApproverId == approverId, "EmployeeId");
    //        eEmployees = eEmployees.OrderByDescending(a => a.EmployeeId).ToList();
    //        return Employees(eEmployees);
    //    }

    //    public List<Employee> ReadRequested(int employeeId)
    //    {
    //        List<EEmployee> eEmployees = _iDEmployee.Read <EEmployee>(a => a.EmployeeId == employeeId, "EmployeeId");
    //        eEmployees = eEmployees.OrderByDescending(a => a.EmployeeId).ToList();
    //        return Employees(eEmployees);
    //    }
    //    #endregion

    //    #region Update
    //    public Employee Update(Employee employee)
    //    {
    //        EEmployee eEmployee = EEmployee(employee);
    //        eEmployee.UpdatedDate = DateTime.Now;
    //        eEmployee = _iDEmployee.Update(eEmployee);
    //        return Employee(eEmployee);
    //    }

    //    public void Approve(int approvedBy, int employeeId)
    //    {
    //        EEmployee eEmployee = _iDEmployee.Read<EEmployee>(a => a.EmployeeId == employeeId);
    //        eEmployee.UpdatedDate = DateTime.Now;
    //        eEmployee.UpdatedBy = approvedBy;

    //        eEmployee.ApprovedDate = DateTime.Now;
    //        eEmployee.ApprovedBy = approvedBy;
    //        _iDEmployee.Update(eEmployee);
    //    }
    //    #endregion

    //    #region Delete
    //    public void Delete(int employeeId)
    //    {
    //        _iDEmployee.Delete<EEmployee>(a => a.EmployeeId == employeeId);
    //    }
    //    #endregion

    //    #region Other Function
    //    private EEmployee EEmployee(Employee employee)
    //    {
    //        return new EEmployee
    //        {
    //            ApprovedDate = employee.ApprovedDate,
    //            ApprovedBy = employee.ApprovedBy,
    //            ApproverId = employee.ApproverId,
    //            ByodId = employee.ByodId,
    //            EmployeeId = employee.EmployeeId,
    //            RequestedBy = employee.RequestedBy,
    //            TypeOfDeviceId = employee.TypeOfDeviceId,
    //            BrandName = employee.BrandName,
    //            ContactNo = employee.ContactNo,
    //            Email = employee.Email,
    //            SerialNumber = employee.SerialNumber,
    //        };
    //    }

    //    private Employee Employee(EEmployee eEmployee)
    //    {
    //        return new Byod
    //        {
    //            ApprovedDate = eEmployee.ApprovedDate,
    //            ApprovedBy = eEmployee.ApprovedBy,
    //            ApproverId = eEmployee.ApproverId,
    //            ByodId = eEmployee.ByodId,
    //            EmployeeId = eEmployee.EmployeeId,
    //            RequestedBy = eEmployee.RequestedBy,
    //            TypeOfDeviceId = eEmployee.TypeOfDeviceId,
    //            BrandName = eEmployee.BrandName,
    //            ContactNo = eEmployee.ContactNo,
    //            Email = eEmployee.Email,
    //            SerialNumber = eEmployee.SerialNumber,
    //        };
    //    }

    //    private List<Employee> Employees(List<EEmployee> eEmployees)
    //    {
    //        return eEmployees.Select(a =>
    //            new Employee
    //            {
    //                ApprovedDate = a.ApprovedDate,
    //                ApprovedBy = a.ApprovedBy,
    //                ApproverId = a.ApproverId,
    //                ByodId = a.ByodId,
    //                EmployeeId = a.EmployeeId,
    //                RequestedBy = a.RequestedBy,
    //                TypeOfDeviceId = a.TypeOfDeviceId,
    //                BrandName = a.BrandName,
    //                ContactNo = a.ContactNo,
    //                Email = a.Email,
    //                SerialNumber = a.SerialNumber,
    //            }
    //            ).ToList();
    //    }
    //    #endregion
    //}
}