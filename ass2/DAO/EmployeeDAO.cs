using ass2.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass2.DAO
{
    class EmployeeDAO
    {
        private static EmployeeDAO instance; // Ctrl + R + E

        public static EmployeeDAO Instance
        {
            get { if (instance == null) instance = new EmployeeDAO(); return EmployeeDAO.instance; }
            private set { EmployeeDAO.instance = value; }
        }

        private EmployeeDAO() { }
        public Employee SelectNVByID(int id)
        {
            Employee re;
            string query = "SELECT * FROM EMPLOYEE WHERE id = @id";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[]{ id});
            foreach (DataRow item in data.Rows)
            {
                re = new Employee(item);
                return re;
            }
            return null;
        }
    }
}
