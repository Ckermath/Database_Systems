using System;
using SQL_Form1.Objects;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQL_Form1.dbAccess;

namespace SQL_Form1.gui
{
    public partial class SearchForm : Form
    {
        private Database db = new Database();
        public SearchForm()
        {
            InitializeComponent();
            db = new Database();
            initComboBox();
            if (db.Connect())
            {
                MessageBox.Show("Database Connection Successful.", "Success");
            }
            else
            {
                MessageBox.Show("Database Connection Unsuccessful.","Error");
            }
        }
        public void initComboBox()
        {
            string[] queryItems = { "Select all projects that have a budget of over 15000",
                                    "Select all projects that M Phillips manages" };

            foreach (string s in queryItems)
            {
                queryCBox.Items.Add(s);
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            ProjectDBAccess pDBAccess = new ProjectDBAccess(db);
            DataTable dt = new DataTable();

            if (queryCBox.SelectedIndex == -1)
                MessageBox.Show("You have not selected a query");
            else
            {
                switch(queryCBox.SelectedIndex)
                {
                    case 0:
                        {
                            pDBAccess.GetAllProjectsWithBudget(1500, 4);
                            dt = pDBAccess.GetProjectDataTable();
                            resultsDataGrid.DataSource = dt;   
                            break;
                        }
                    case 1:
                        {
                            pDBAccess.getAllProjectsWithManager("M Phillips");
                            dt = pDBAccess.GetProjectDataTable();
                            resultsDataGrid.DataSource = dt;
                            break;
                        }
                    default: resultSizeLabel.Text = "0";break;
                }
            }
            
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch2_Click(object sender, EventArgs e)
        {
            int projectID = Convert.ToInt32(projectTxtbox.Text);
            ProjectDBAccess p = new ProjectDBAccess(db);
            p.GetProjectWithID(projectID);

            List<Project> results = p.GetProjectObjects();
            foreach  (Project proj in results)
            {
                MessageBox.Show ($"ProjectID: {proj.Id}\nProject Title: {proj.Name}\nProject Manager: {proj.ManagerName}\nProject Budget: {proj.Budget}\n");
            }
        }

        public void UpdateTable(Project p)
        {
            db.Cmd.CommandText = "UPDATE Project SET ProjectTitle = '" + p.Name + "', ProjectManager = '" + p.ManagerName + "', ProjectBudget = '" + p.Budget + "', ProjectStartDate = '" + p.ProjectStartDate1 + "', ProjectEndDate = '" + p.ProjectEndDate1 + "', ProjectCompleted = '" + p.ProjectCompleted1 + "' where projectCode = " + p.Id;
            db.Cmd.ExecuteNonQuery();
        }

        private void projectTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void queryCBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
