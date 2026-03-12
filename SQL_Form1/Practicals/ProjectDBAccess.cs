using SQL_Form1.Objects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Form1.dbAccess
{
    class ProjectDBAccess
    {
        private Database db;

        public ProjectDBAccess(Database _db)
        {
            db = _db;
        }
        public Project getProjectFromReader()
        {
            Project proj = new Project();
            proj.Id = db.Rdr.GetInt32(0);
            proj.Name = db.Rdr.GetString(1);
            proj.ManagerName = db.Rdr.GetString(1);
            proj.Budget = db.Rdr.GetDecimal(3);
            proj.ProjectStartDate1 = db.Rdr.GetDateTime(4);
            proj.ProjectEndDate1 = db.Rdr.GetDateTime(5);
            proj.ProjectCompleted1 = db.Rdr.GetBoolean(6);
            return proj;
        }
        public List<Project> GetProjectObjects()
        {
            List<Project> results = new List<Project>();
            while (db.Rdr.Read())
            {
                results.Add(getProjectFromReader());
            }
            db.Rdr.Close();
            return results;
        }

        public void GetEmployeesFromProject(int projectID)
        {
            string sqlCmd = $"select e.EmployeeNo, e.EmployeeName, d.DepartmentNo, d.DepartmentName from ProjectEmployee pe inner join employee e on e.EmployeeNo = pe.EmployeeNo inner join department d on d.DepartmentNo = e.DepartmentNo where ProjectCode = {projectID}";
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = sqlCmd;
            db.Rdr = db.Cmd.ExecuteReader();
        }

        public void GetAllProjectsWithName(string name)
        {
            string sqlCmd = $"Select * From Project Where ProjectTitle Like '%{name}%'";
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = sqlCmd;
            db.Rdr = db.Cmd.ExecuteReader();
        }

        public Project GetProjectObject()
        {
            Project project = new Project();
            while (db.Rdr.Read())
            {
                project = getProjectFromReader();
            }
            db.Rdr.Close();
            return project;
        }

        public DataTable GetProjectDataTable()
        {
            DataTable dt = new DataTable();
            dt.Load(db.Rdr);
            return dt;
        }

        public void GetAllProjects()
        {
            string sqlCmd = "SELECT * FROM Project";
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = sqlCmd;
            db.Rdr = db.Cmd.ExecuteReader();
        }
        public void GetProjectWithID(int id)
        {
            string sqlCmd = "SELECT * FROM Project WHERE ProjectCode = " + id;
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = sqlCmd;
            db.Rdr = db.Cmd.ExecuteReader();
        }

        public void AddNewProject(Project p)
        {
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = "INSERT INTO Project(ProjectTitle,ProjectManager,ProjectBudget,ProjectStartDate,ProjectEndDate,ProjectCompleted) VALUES('" + p.Name + "','" + p.ManagerName + "'," + p.Budget + ",'" + p.ProjectStartDate1.ToString("MM/dd/yyyy") + "','" + p.ProjectEndDate1.ToString("MM/dd/yyyy") + "','" + p.ProjectCompleted1 + "')";
            db.Cmd.ExecuteNonQuery();
        }

        public void GetAllProjectsWithBudget(decimal rate, int op)
        {
            String sqlCmd = "SELECT * FROM Project WHERE ProjectBudget";
            switch (op)
            {
                case 1: sqlCmd += "="; break;
                case 2: sqlCmd += ">="; break;
                case 3: sqlCmd += "<="; break;
                case 4: sqlCmd += ">"; break;
                case 5: sqlCmd += "<"; break;
                case 6: sqlCmd += "<>"; break;
                default: sqlCmd += "="; break;
            }

            sqlCmd += rate.ToString();
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = sqlCmd;
            db.Rdr = db.Cmd.ExecuteReader();
        }
        public void getAllProjectsWithManager(string manager)
        {
            String sqlCmd = "SELECT * FROM Project WHERE ProjectManager ='" + manager + "'";
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = sqlCmd;
            db.Rdr = db.Cmd.ExecuteReader();
        }

        public void UpdateTable(Project p)
        {
            string sqlCmd = $"update Project set ProjectTitle = '{p.Name}', ProjectManager = '{p.ManagerName}', ProjectBudget = {p.Budget}, ProjectStartdate = '{p.ProjectStartDate1.ToString("MM/dd/yyyy")}', ProjectEndDate = '{p.ProjectEndDate1.ToString("MM/dd/yyyy")}', ProjectCompleted = '{p.ProjectCompleted1}' where projectCode = {p.Id}; ";
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = sqlCmd;
            db.Cmd.ExecuteNonQuery();
        }

        public int GetLastProject()
        {
            string sqlCmd = "Select max(projectcode) from Project";
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = sqlCmd;
            db.Rdr = db.Cmd.ExecuteReader();
            return GetProjectCodeFromReader();
        }

        public int GetProjectCodeFromReader()
        {
            int num = 0;
            while (db.Rdr.Read())
            {
                num = db.Rdr.GetInt32(0);
            }
            db.Rdr.Close();
            return num;
        }
    }
}