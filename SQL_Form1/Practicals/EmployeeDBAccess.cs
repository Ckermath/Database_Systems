using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQL_Form1.Objects;

namespace SQL_Form1.Objects
{
    public class EmployeeDBAccess
    {
        private Database db;
        public EmployeeDBAccess(Database _db)
        {
            db = _db;
        }
        public void getEmployees()
        {
            string sqlCmd = "select * from Employee order by EmployeeName ASC";
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = sqlCmd;
            db.Rdr = db.Cmd.ExecuteReader();
        }
        public void GetAllEmployeeByName(string name)
        {
            Employee emp = new Employee();
            string sqlCmd = $"select EmployeeNo from Employee where EmployeeName = '{name}'";
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = sqlCmd;
            db.Rdr = db.Cmd.ExecuteReader();
        }
        public Employee GetEmployeeFromReader()
        {
            Employee emp = new Employee();
            emp.EmpId = db.Rdr.GetInt32(0);
            emp.Name = db.Rdr.GetString(1);

            return emp;
        }

        public List<Employee> GetEmployeeObjects()
        {
            List<Employee> results = new List<Employee>();
            while (db.Rdr.Read())
            {
                results.Add(GetEmployeeFromReader());
            }
            db.Rdr.Close();
            return results;
        }

    }
}
