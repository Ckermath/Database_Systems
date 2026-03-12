using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQL_Form1.Objects;

namespace SQL_Form1.dbAccess
{
    class ProjectEmployeeDBAccess
    {
        private Database db;
        public ProjectEmployeeDBAccess(Database _db)
        {
            db = _db;
        }

        public int CreateProjectEmployee()
        {
            Project proj = new Project();
            Employee emp = new Employee();
            proj.Id = db.Rdr.GetInt32(0);
            emp.DeptNo = db.Rdr.GetInt32(0);
            string sqlCmd = ("Insert Into ProjectEmployee (projectcode, EmployeeNo) values('" + proj.Id + "','" + emp.EmpId);
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = sqlCmd;
            db.Rdr = db.Cmd.ExecuteReader();
            return db.Cmd.ExecuteNonQuery();
        }
    }
}
