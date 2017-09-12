using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace AndersonFormsModel
{
    class CRMmodel
    {
        public class Employee : Base.Base
        {
            public int EmployeeId { get; set; }
        }

        public class EmployeeContext
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MYConnector"].ToString());
            private IEnumerable<Employee> result;

            public SqlConnection Con { get => connection; set => connection = value; }

            public IEnumerable<Employee> GetEmployeeList()
            {
                return result;
            }
        }
    }
}