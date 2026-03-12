using SQL_Form1.dbAccess;
using SQL_Form1.GUI;
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

namespace SQL_Form1
{
    public partial class CreateWeddingListForm : Form
    {
        private Database db = WeddingListMenu.Db;
        public CreateWeddingListForm()
        {
            InitializeComponent();
        }


        private void BtnCreateWeddingList_Click(object sender, EventArgs e)
        {
            bool valid = true;
            WeddingListDBAccess WedL = new WeddingListDBAccess(db);
            WeddingList weddingList = new WeddingList();
            try
            {
                weddingList.ClientForename = txtForename.Text;
                
            }
            catch (Exception)
            {
                MessageBox.Show("Forename is invalid");
                valid = false;
            }
            try
            {
                weddingList.ClientContactNo = txtTelephone.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("Telephone number is invalid");
                valid = false;
            }
            try
            {
                weddingList.ClientSurname = txtSurname.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("Surname is Invalid");
                valid = false;
            }
            try
            {
                weddingList.PostCode = txtPostcode.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("Postcode is invalid");
            }
            try
            {
                weddingList.HouseNumber = Convert.ToInt32(txtHouseNo.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("House number is invalid");
                valid = false;
            }
            try
            {
                weddingList.StreetName = txtStreetName.Text;
            }
            catch (Exception)
            {

                MessageBox.Show("Street Name is invalid");
                valid = false;
            }
            try
            {
                weddingList.SetupDate = DateTime.Now;
                weddingList.EventDate = calEvent.SelectionStart;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                valid = false;
            }
            try
            {
                weddingList.TownName = txtTownName.Text;
            }
            catch (Exception)
            {

                MessageBox.Show("The Town Name is invalid");
                valid = false;
            }
            try
            {
                weddingList.EmployeeName = txtEmployee.Text;
            }
            catch (Exception)
            {

                MessageBox.Show("Employee Name is invalid");
                valid = false;
            }
            if (valid == true)
            {
            WedL.AddNewWeddingList(weddingList);
            MessageBox.Show("Wedding List added");
            ClearAllData();
            }
        }

        private void CreateWeddingListForm_Load(object sender, EventArgs e)
        {

        }

        private void ClearAllData()
        {
            txtForename.Text = "";
            txtSurname.Text = "";
            txtHouseNo.Text = "";
            txtStreetName.Text = "";
            txtTownName.Text = "";
            txtPostcode.Text = "";
            txtTelephone.Text = "";
            txtEmployee.Text = "";
            //calSetup.SelectionStart = DateTime.Now;
            calEvent.SelectionStart = DateTime.Now;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAllData();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
                WeddingListMenu wlMenu = new WeddingListMenu();
                wlMenu.Show();
                this.Hide();
        }
    }
}
