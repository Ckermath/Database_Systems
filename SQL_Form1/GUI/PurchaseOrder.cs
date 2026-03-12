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
    public partial class PurchaseOrder : Form
    {
        private Database Db = WeddingListMenu.Db;
        List<Product> prices = new List<Product>();
        public PurchaseOrder()
        {
            InitializeComponent();
            PopulateDGV();
        }

        private void PopulateDGV()
        {
            dgvProduct.Columns.Clear();
            DataGridViewComboBoxColumn dgvCmb = new DataGridViewComboBoxColumn();
            dgvCmb.HeaderText = "Select Product";
            dgvCmb.Width = 200;

            ProductDBAccess product = new ProductDBAccess(Db);

            product.GetAllProductsDetails();
            List<Product> products = product.GetProductList();
            dgvCmb.Items.Clear();
            foreach (Product p in products)
            {
                dgvCmb.Items.Add(p.ProductCode + "-" + p.ProductName);
            }

            dgvCmb.Name = "cmbProduct";
            dgvProduct.Columns.Add(dgvCmb);

            DataGridViewTextBoxColumn dgvTxt = new DataGridViewTextBoxColumn();
            dgvTxt.HeaderText = "Quantity";
            dgvTxt.Name = "txtQty";
            dgvProduct.Columns.Add(dgvTxt);

            DataGridViewTextBoxColumn txtDGV = new DataGridViewTextBoxColumn();
            txtDGV.HeaderText = "Line Total";
            txtDGV.Name = "txtTotal";
            dgvProduct.Columns.Add(txtDGV);

            DataGridViewButtonColumn dgvBtn = new DataGridViewButtonColumn();
            dgvBtn.UseColumnTextForButtonValue = true;
            dgvBtn.Name = "btnDelete";
            dgvBtn.Text = "Remove";
            dgvBtn.HeaderText = "";
            dgvBtn.HeaderCell.Style.BackColor = Color.White;
            dgvProduct.Columns.Add(dgvBtn);
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            WeddingListMenu wlMenu = new WeddingListMenu();
            wlMenu.Show();
            this.Hide();
        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && senderGrid.CurrentRow.Cells[0].Value != null)
            {
                dgvProduct.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void cbxWeddingList_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateDGV();
        }

        private void ComboSelectionChanged(object sender, EventArgs e)
        {
            Product product = new Product();
            ProductDBAccess productDBAccess = new ProductDBAccess(Db);
            ComboBox combo = (ComboBox)sender;
            string[] productDetails = combo.Text.Split('-');
            int productCode = Convert.ToInt32(productDetails[0]);
            productDBAccess.LineTotal(productCode);
            product = productDBAccess.GetProductObject();
            product.ProductCode = productCode;
            if (!prices.Contains(product))
                prices.Add(product);
        }

        private void btnConfirmOrder_Click(object sender, EventArgs e)
        {
            bool accepted = true;
            OrderDBAccess orderDBAccess = new OrderDBAccess(Db);
            Order order = new Order();
            WeddingListOrder weddingListOrder = new WeddingListOrder();
            WeddingListOrderDBAccess weddingListOrderDBAccess = new WeddingListOrderDBAccess(Db);
            OrderProductDBAccess orderProductDBAccess = new OrderProductDBAccess(Db);

            if (txtBoxStaffName.Text == "" || txtBoxStaffName.Text.Length >=50)
            {
                accepted = false;
            }
            if (accepted)
            {
                order.Employee1 = txtBoxStaffName.Text;
                order.OrderDate1 = DateTime.Today;
                orderDBAccess.InsertOrder(order);
                orderDBAccess.PreviousOrder();
                int OrderCode = orderDBAccess.GetOrderCode();
                for (int i = 0; i <= dgvProduct.Rows.Count; i++)
                {
                    OrderProductDBAccess orderProdDBAccess = new OrderProductDBAccess(Db);
                    OrderProduct op = new OrderProduct();
                    OrderDBAccess oDBAccess = new OrderDBAccess(Db);
                    string[] prods = dgvProduct.Rows[i].Cells[0].Value.ToString().Split('-');
                    int quantity = Convert.ToInt32(dgvProduct.Rows[i].Cells[1].Value.ToString());
                    op.OrderCode = OrderCode;
                    op.ProductCode = Convert.ToInt32(prods[0]);
                    op.Qty = quantity;
                    orderProdDBAccess.InsertOrderProduct(op);
                }
                MessageBox.Show("Successful");
            }
            else
                MessageBox.Show("Unsuccessful");

        }

        private void dgvProduct_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvProduct.CurrentCell.ColumnIndex == 0 && e.Control is ComboBox)
            {
                ComboBox comboBox = e.Control as ComboBox;
                comboBox.SelectedIndexChanged -= ComboSelectionChanged;
                comboBox.SelectedIndexChanged += ComboSelectionChanged;
            }
            else if (dgvProduct.CurrentCell.ColumnIndex == 1 && e.Control is TextBox)
            {
                TextBox text = e.Control as TextBox;
                text.TextChanged -= TextBoxChanged;
                text.TextChanged += TextBoxChanged;
              
            }
        }

        private void Text_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        private void TextBoxChanged(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (txt.Text != "")
            {
                try
                {
                    ProductDBAccess productDBAccess = new ProductDBAccess(Db);
                    string[] details = dgvProduct.Rows[dgvProduct.CurrentCell.RowIndex].Cells[0].Value.ToString().Split('-');
                    int pCode = Convert.ToInt32(details[0]);
                    Product product = prices.Find(p => p.ProductCode == pCode);
                    int qty = Convert.ToInt32(txt.Text);
                    dgvProduct.Rows[dgvProduct.CurrentCell.RowIndex].Cells[2].Value = qty * product.ProductPrice;
                }
                catch (Exception)
                {
                    MessageBox.Show("You must enter a number");
                }
            }
            else
                dgvProduct.Rows[dgvProduct.CurrentCell.RowIndex].Cells[2].Value = "";
        }

        private void UpdateFullTotal()
        {

        }

        private void btnWeddingListO_Click(object sender, EventArgs e)
        {
            CreateOrder Co = new CreateOrder();
            Co.Show();
            this.Hide();
        }

        private void PurchaseOrder_Load(object sender, EventArgs e)
        {

        }

        private void btnPurchaseOrder_Click(object sender, EventArgs e)
        {
            PurchaseOrder PO = new PurchaseOrder();
            PO.Show();
            this.Hide();
        }
    }
}
