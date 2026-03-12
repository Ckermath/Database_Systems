using SQL_Form1.dbAccess;
using SQL_Form1.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_Form1.gui
{
    public partial class AddProject : Form
    {
        Database db = MainApp.Db;
        ProjectDBAccess p;
        EmployeeDBAccess eDBAccess = new EmployeeDBAccess(MainApp.Db);
        ProjectDBAccess pDBAccess = new ProjectDBAccess(MainApp.Db);

        public AddProject()
        {
            InitializeComponent();
            p = new ProjectDBAccess(db);
            eDBAccess = new EmployeeDBAccess(db);
            PopulateAvailableEmployees();
        }

        private void projectSelected(object sender, EventArgs e)
        {
            Project result = pDBAccess.GetProjectObject();
            txtProjTitle.Text = result.Name;
            txtProjManager.Text = result.ManagerName;
            txtProjBudget.Text = result.Budget.ToString();
            calStartDate.SetDate(result.ProjectStartDate1);
            calEndDate.SetDate(result.ProjectEndDate1);
            ProjectCompletedCheckbox.Checked = result.ProjectCompleted1;
        }
        private void ClearAllData()
        {
            txtProjBudget.Text = "";
            txtProjManager.Text = "";
            txtProjTitle.Text = "";

            calStartDate.SelectionStart = DateTime.Now;
            calEndDate.SelectionStart = DateTime.Now;

            ProjectCompletedCheckbox.Checked = false;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool valid = true;
            ProjectDBAccess pdbAccess = new ProjectDBAccess(db);
            EmployeeDBAccess eDBAccess = new EmployeeDBAccess(db);
            ProjectEmployeeDBAccess peDBAccess = new ProjectEmployeeDBAccess(db);
            Project project = new Project();
            project.Name = txtProjTitle.Text;

                try
                {
                    project.ManagerName = txtProjManager.Text;
                }
                catch (Exception ex)
                {
                    errorslbl.Text += "\n" + ex.Message;
                    valid = false;
                }

                try
                {
                    project.Budget = Convert.ToDecimal(txtProjBudget.Text);

                }
                catch (Exception ex)
                {
                    errorslbl.Text += "\n" + ex.Message;
                    valid = false;
                }

                try
                {
                    project.ProjectStartDate1 = calStartDate.SelectionStart;
                }
                catch (Exception ex)
                {
                    errorslbl.Text += "\n" + ex.Message;
                    valid = false;
                }

                try
                {
                    project.ProjectEndDate1 = calEndDate.SelectionStart;
                }
                catch (Exception ex)
                {
                    errorslbl.Text += "\n" + ex.Message;
                    valid = false;
                }

                project.ProjectCompleted1 = ProjectCompletedCheckbox.Checked;

                if (valid)
                {
                    pdbAccess.AddNewProject(project);
                foreach (var employee in lboxSelectedEmployees.Items)
                {
                    eDBAccess.GetAllEmployeeByName(employee.ToString());
                    Employee emp = eDBAccess.GetEmployeeFromReader();
                    int employeeID = emp.EmpId;
                    int projectID = pdbAccess.GetLastProject();
                    peDBAccess.CreateProjectEmployee();
                }

                MessageBox.Show("Project Added");
                }
        }

        private void PopulateAvailableEmployees()
        {
            EmployeeDBAccess e = new EmployeeDBAccess(db);
            e.getEmployees();
            List<Employee> employees = e.GetEmployeeObjects();
            foreach (Employee emp in employees)
            {
                lboxAvailableEmployees.Items.Add(emp.Name);
            }
        }

        private void btnClearData_Click(object sender, EventArgs e)
        {
            ClearAllData();
        }

        private void AddProject_Load(object sender, EventArgs e)
        {

        }

        private void btnDeselect_Click(object sender, EventArgs e)
        {
            lboxAvailableEmployees.Items.Add(lboxSelectedEmployees.SelectedItem.ToString());
            lboxSelectedEmployees.Items.Remove(lboxSelectedEmployees.SelectedItem.ToString());
            lboxAvailableEmployees.Sorted = true;
            lboxSelectedEmployees.Sorted = true;
        }

        private void btnSelected_Click(object sender, EventArgs e)
        {
            lboxSelectedEmployees.Items.Add(lboxAvailableEmployees.SelectedItem.ToString());
            lboxAvailableEmployees.Items.Remove(lboxAvailableEmployees.SelectedItem.ToString());
            lboxAvailableEmployees.Sorted = true;
            lboxSelectedEmployees.Sorted = true;
        }
    }
}
