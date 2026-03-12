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
    public partial class EditForm : Form
    {
        Database db = MainApp.Db;
        ProjectDBAccess pdbAccess = new ProjectDBAccess(MainApp.Db);

        public EditForm()
        {
            InitializeComponent();

            pdbAccess.GetAllProjects();
            List<Project> projects = pdbAccess.GetProjectObjects();
            foreach (Project p in projects)
            {
                comboBox1.Items.Add($"{p.Id}-{p.Name}");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("You must select a project");
            }
            else
            {
                string[] selectedProject = new string[2];
                selectedProject = comboBox1.SelectedItem.ToString().Split('-');
                int projectCode = Convert.ToInt32(selectedProject[0]);
                pdbAccess.GetProjectWithID(projectCode);
                Project result = pdbAccess.GetProjectObject();
                txtProjectID.Text = result.Id.ToString();
                txtProjTitle.Text = result.Name;
                txtProjManager.Text = result.ManagerName;
                txtProjBudget.Text = result.Budget.ToString();
                calStartDate.SetDate(result.ProjectStartDate1);
                calEndDate.SetDate(result.ProjectEndDate1);
                ProjectCompletedCheckbox.Checked = result.ProjectCompleted1;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            bool valid = true;
            errorslbl.Text = "";
            ProjectDBAccess pdbAccess = new ProjectDBAccess(db);
            Project project = new Project();
            project.Id = Convert.ToInt32(txtProjectID.Text);
            project.Name = txtProjTitle.Text;

            if (comboBox1.SelectedIndex == -1) MessageBox.Show("You have not selected a project");
            else
            {

                try
                {
                    project.ManagerName = txtProjManager.Text;
                }
                catch (Exception ex)
                {
                    errorslbl.Text += "/n" + ex.Message;
                    MessageBox.Show(ex.Message);
                    valid = false;
                }

                try
                {
                    project.Budget = Convert.ToDecimal(txtProjBudget.Text);

                }
                catch (Exception ex)
                {
                    errorslbl.Text += "/n" + ex.Message;
                    MessageBox.Show(ex.Message);
                    valid = false;
                }

                try
                {
                    project.ProjectStartDate1 = calStartDate.SelectionStart;
                }
                catch (Exception ex)
                {
                    errorslbl.Text += "/n" + ex.Message;
                    MessageBox.Show(ex.Message);
                    valid = false;
                }

                try
                {
                    project.ProjectEndDate1 = calEndDate.SelectionStart;
                }
                catch (Exception ex)
                {
                    errorslbl.Text += "/n" + ex.Message;
                    MessageBox.Show(ex.Message);
                    valid = false;
                }

                project.ProjectCompleted1 = ProjectCompletedCheckbox.Checked;

                if (valid)
                {
                    pdbAccess.UpdateTable(project);
                    MessageBox.Show("Project Updated");
                }
            }
        }

        private void btnClearData_Click(object sender, EventArgs e)
        {
            ClearAllData();
        }
        private void ClearAllData()
        {
            txtProjBudget.Text = "";
            txtProjectID.Text = "";
            txtProjManager.Text = "";
            txtProjTitle.Text = "";

            calStartDate.SelectionStart = DateTime.Now;
            calEndDate.SelectionStart = DateTime.Now;

            ProjectCompletedCheckbox.Checked = false;

        }
    }
}
