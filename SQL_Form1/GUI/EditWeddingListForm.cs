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

namespace SQL_Form1.GUI
{
    public partial class EditWeddingListForm : Form
    {
        private Database db = WeddingListMenu.Db;
        public EditWeddingListForm()
        {
            InitializeComponent();
        }

        public EditWeddingListForm(WeddingList wedding)
        {
            InitializeComponent();
            txtboxForename.Text = wedding.ClientForename;
            txtboxSurname.Text = wedding.ClientSurname;
            txtboxTelephone.Text = wedding.ClientContactNo;
            calenderEvent.SelectionStart = wedding.EventDate;
            calenderSetup.SelectionEnd = wedding.SetupDate;
            txtboxEmployee.Text = wedding.EmployeeName;
            txtboxPostcode.Text = wedding.PostCode;
            txtboxHouseNo.Text = wedding.HouseNumber.ToString();
            txtboxTownName.Text = wedding.TownName;
            txtboxStreetName.Text = wedding.StreetName;
        }

        public void UpdateWeddingList(WeddingList WedList)
        {
            db.Cmd = db.Conn.CreateCommand();
            string sqlCmd = $"UPDATE WeddingList SET ClientForename = {WedList.ClientForename} + ClientSurname = {WedList.ClientSurname} + ClientContactNo = {WedList.ClientContactNo} + EventDate = {WedList.EventDate} + SetupDate = {WedList.SetupDate} + EmployeeName = {WedList.EmployeeName} + PostCode = {WedList.PostCode} + HouseNumber = {WedList.HouseNumber} + TownName = {WedList.TownName} + StreetName = {WedList.StreetName}";
            db.Cmd.CommandText = sqlCmd;
            db.Rdr = db.Cmd.ExecuteReader();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ManageWeddingListForm manageWeddingListForm = new ManageWeddingListForm();
            manageWeddingListForm.Show();
            this.Hide();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            WeddingListMenu wlMenu = new WeddingListMenu();
            wlMenu.Show();
            this.Hide();
        }
    }
}
