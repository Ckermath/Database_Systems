using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQL_Form1.GUI;

namespace SQL_Form1.Objects
{
    public partial class WeddingListMenu : Form
    {
        private static Database db;
        public static Database Db { get => db; set => db = value; }
        public WeddingListMenu()
        {
            InitializeComponent();
            db = new Database();
            if (!Db.Connect())
            {
                MessageBox.Show("Database Connection Unsuccessful.", "Error");
            }
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            CreateWeddingListForm createWeddingListForm = new CreateWeddingListForm();
            createWeddingListForm.Show();
            this.Hide();
        }
        private void WeddingListForm_Load(object sender, EventArgs e)
        {

        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            ManageWeddingListForm manageWeddingListForm = new ManageWeddingListForm();
            manageWeddingListForm.Show();
            this.Hide();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnOrderProducts_Click(object sender, EventArgs e)
        {
            CreateOrder createOrder = new CreateOrder();
            createOrder.Show();
            this.Hide();
        }
    }
}
