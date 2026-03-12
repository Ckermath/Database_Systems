using System;
using SQL_Form1.Objects;
using SQL_Form1.dbAccess;
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
    public partial class ExtentionTask : Form
    {
        Database db;
        public ExtentionTask()
        {
            InitializeComponent();
    }
        private void ProjectName_TextChanged(object sender, EventArgs e)
        {
            db = MainApp.Db;
            ProjectDBAccess pDBAccess = new ProjectDBAccess(db);
            DataTable dt = new DataTable();


            string search = txtboxprojectName.Text;
            try
            {
                int id = Convert.ToInt32(search);
                pDBAccess.GetProjectWithID(id);
                dt = pDBAccess.GetProjectDataTable();
                projectDataGridView.DataSource = dt;

            }
            catch
            {
                pDBAccess.GetAllProjectsWithName(search);
                dt = pDBAccess.GetProjectDataTable();
                projectDataGridView.DataSource = dt;
            }

        }



        private void projectGridView_SelectionChanged(object sender, EventArgs e)
        {
            employeesGridView.Visible = true;

            ProjectDBAccess pDBAccess = new ProjectDBAccess(db);
            DataTable dt = new DataTable();

            int project = int.Parse(projectDataGridView.CurrentRow.Cells[0].Value.ToString());

            pDBAccess.GetEmployeesFromProject(project);
            dt = pDBAccess.GetProjectDataTable();
            employeesGridView.DataSource = dt;
            lblNumOfEmployees.Text = $"Number of Employees: {employeesGridView.RowCount - 1}";
        }

        private void searchbtn4_Click(object sender, EventArgs e)
        {
            ProjectDBAccess pDBAccess = new ProjectDBAccess(db);
            DataTable dt = new DataTable();

            if (txtboxprojectName.Text == "")
                MessageBox.Show("You have not selected a query");
            else
            {
                string projectTitle = txtboxprojectName.Text;
                pDBAccess.GetAllProjectsWithName(projectTitle);
                dt = pDBAccess.GetProjectDataTable();
                projectDataGridView.DataSource = dt;

            }
        }
    }
}
