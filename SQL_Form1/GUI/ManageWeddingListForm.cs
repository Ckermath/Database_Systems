using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQL_Form1.Objects;
using SQL_Form1.dbAccess;

namespace SQL_Form1.GUI
{
    public partial class ManageWeddingListForm : Form
    {
        int weddingListNo = 0;
        int productCode;
        string forename;
        bool buttonsadded = false;
        DataGridViewTextBoxColumn dgvProduct = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn dgvQty = new DataGridViewTextBoxColumn();
        WeddingList wl = new WeddingList();

        public ManageWeddingListForm()
        {
            InitializeComponent();
            PopulateProducts();
        }

        private Database db = WeddingListMenu.Db;
        private void btnEditWeddingList_Click(object sender, EventArgs e)
        {
            EditWeddingListForm editWeddingListForm = new EditWeddingListForm(wl);
            editWeddingListForm.Show();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtBoxSearchForWL.Text != "")
            {
                ProductDBAccess prodDBAccess = new ProductDBAccess(db);
                DataTable dt = new DataTable();
                try
                {
                    string customerName = txtBoxSearchForWL.Text; 
                }
                catch
                {

                    throw;
                }
                string Forename = txtBoxSearchForWL.Text;
                forename = Forename;
                prodDBAccess.FindPDetails(Forename);
                List<Product> products = prodDBAccess.GetManageProductList();

                WeddingListDBAccess W = new WeddingListDBAccess(db);
                W.GetAllWeddingList(Forename);
                List<WeddingList> results = W.GetWeddingListObjects();
                foreach (WeddingList WeLi in results)
                {
                    lblWeddingListDetails.Text = $"Wedding List Number: {WeLi.WeddingListNo}\nForename: {WeLi.ClientForename}\nSurname: {WeLi.ClientSurname}\nHouse Number: {WeLi.HouseNumber}\nStreet Name: {WeLi.StreetName}\nTown Name: {WeLi.TownName}\nPostcode: {WeLi.PostCode}\nTelephone Number: {WeLi.ClientContactNo}\nEmployee Name: {WeLi.EmployeeName}";
                    wl = WeLi;
                    weddingListNo = WeLi.WeddingListNo;
                }
                updateDataGrid();
                btnEditWeddingList.Visible = true;
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            WeddingListMenu wlMenu = new WeddingListMenu();
            wlMenu.Show();
            this.Hide();
        }
        private void PopulateProducts()
        {
            ProductDBAccess productDBAccess = new ProductDBAccess(db);
            productDBAccess.GetAllProductsDetails();
            List<Product> products = productDBAccess.GetProductList();
            foreach (Product p in products)
            {
                comboBoxProduct.Items.Add($"{p.ProductCode}-{ p.ProductName}");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ProductDBAccess productDBAccess = new ProductDBAccess(db);
            WeddingListProductDBAccess wlp = new WeddingListProductDBAccess(db);
            List<int> productCodes = new List<int>();
            for (int i = 0; i < WeddingListDataGridView.Rows.Count-1; i++)
            {
                string[] product = WeddingListDataGridView.Rows[i].Cells[0].Value.ToString().Split('-');
                productCodes.Add(Convert.ToInt32(product[0]));
            }
            
            string[] productDetails = comboBoxProduct.Text.Split('-');
            int productCode = Convert.ToInt32(productDetails[0]);
            int Qty = Convert.ToInt32(txtboxQty.Text);
            try
            {
                if (productCodes.Count == 0)
                {
                    wlp.AddWLProduct(weddingListNo, productCode, Qty);
                    MessageBox.Show("Product added");
                }
                else
                {
                    
                        bool duplicate = false;

                        foreach (int prodID in productCodes)
                        {
                            if (productCode == prodID)
                                {

                            duplicate = true;
                            throw new Exception("Duplicate products selected!");
                        }
                        break;
                        
                        }
                    if (duplicate == false)
                    {
                        wlp.AddWLProduct(weddingListNo, productCode, Qty);
                        MessageBox.Show("Product added");
                    }


                    
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            updateDataGrid();
        }
        private void updateDataGrid()
        {
            ProductDBAccess prodDBAccess = new ProductDBAccess(db);
            string Forename = txtBoxSearchForWL.Text;
            forename = Forename;
            prodDBAccess.FindPDetails(Forename);
            DataTable dt = prodDBAccess.ProductsDataTable();
            WeddingListDataGridView.DataSource = dt;
            WeddingListDataGridView.Columns[0].ReadOnly = true;
            WeddingListDataGridView.Columns[1].ReadOnly = true;
            WeddingListDataGridView.Columns[2].ReadOnly = true;
            WeddingListDataGridView.Columns[3].ReadOnly = true;
            WeddingListDataGridView.Columns[4].ReadOnly = true;
            if (!buttonsadded)
            {
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                DataGridViewButtonColumn UpdateBtn = new DataGridViewButtonColumn();
                btn.HeaderText = "Delete";
                UpdateBtn.HeaderText = "Update";
                WeddingListDataGridView.Columns.Add(UpdateBtn);
                WeddingListDataGridView.Columns.Add(btn);

                buttonsadded = true;
            }

        }

        private void WeddingListDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            WeddingListProductDBAccess weddingListProductDBAccess = new WeddingListProductDBAccess(db);
            var senderGrid = (DataGridView)sender;
            if(senderGrid.CurrentCell is DataGridViewButtonCell && (senderGrid.CurrentCell.ColumnIndex == 9 || senderGrid.CurrentCell.ColumnIndex == 1))
            {
                try
                {
                    productCode = Convert.ToInt32(senderGrid.Rows[e.RowIndex].Cells[0].Value);
                    weddingListProductDBAccess.DeleteWLProduct(wl.WeddingListNo, productCode);
                    senderGrid.Rows.RemoveAt(e.RowIndex);
                }
                catch
                {
                    MessageBox.Show("You cannot delete that row");
                }
            }
            else if (senderGrid.CurrentCell is DataGridViewButtonCell && (senderGrid.CurrentCell.ColumnIndex == 8 || senderGrid.CurrentCell.ColumnIndex == 0))
            {
                try
                {
                    MessageBox.Show("Updated");
                }
                catch
                {
                    MessageBox.Show("You cannot delete that row");
                }
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            updateDataGrid();
        }
    }
}

