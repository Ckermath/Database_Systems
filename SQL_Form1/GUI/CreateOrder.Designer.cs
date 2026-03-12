
namespace SQL_Form1.GUI
{
    partial class CreateOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.lblBackgroundcolour = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnConfirmOrder = new System.Windows.Forms.Button();
            this.lblWedList = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxFullName = new System.Windows.Forms.TextBox();
            this.txtBoxStaffName = new System.Windows.Forms.TextBox();
            this.cbxWeddingList = new System.Windows.Forms.ComboBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblFullTotal = new System.Windows.Forms.Label();
            this.btnPurchaseOrder = new System.Windows.Forms.Button();
            this.btnGenralOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProduct
            // 
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Location = new System.Drawing.Point(219, 251);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.RowHeadersWidth = 62;
            this.dgvProduct.RowTemplate.Height = 28;
            this.dgvProduct.Size = new System.Drawing.Size(1113, 477);
            this.dgvProduct.TabIndex = 0;
            this.dgvProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellContentClick);
            this.dgvProduct.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvProduct_EditingControlShowing);
            // 
            // lblBackgroundcolour
            // 
            this.lblBackgroundcolour.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblBackgroundcolour.Location = new System.Drawing.Point(5, -15);
            this.lblBackgroundcolour.Name = "lblBackgroundcolour";
            this.lblBackgroundcolour.Size = new System.Drawing.Size(173, 884);
            this.lblBackgroundcolour.TabIndex = 4;
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(12, 30);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(156, 40);
            this.btnMenu.TabIndex = 5;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnConfirmOrder
            // 
            this.btnConfirmOrder.Location = new System.Drawing.Point(618, 752);
            this.btnConfirmOrder.Name = "btnConfirmOrder";
            this.btnConfirmOrder.Size = new System.Drawing.Size(273, 86);
            this.btnConfirmOrder.TabIndex = 6;
            this.btnConfirmOrder.Text = "Confirm Order";
            this.btnConfirmOrder.UseVisualStyleBackColor = true;
            this.btnConfirmOrder.Click += new System.EventHandler(this.btnConfirmOrder_Click);
            // 
            // lblWedList
            // 
            this.lblWedList.AutoSize = true;
            this.lblWedList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWedList.Location = new System.Drawing.Point(214, 36);
            this.lblWedList.Name = "lblWedList";
            this.lblWedList.Size = new System.Drawing.Size(145, 25);
            this.lblWedList.TabIndex = 8;
            this.lblWedList.Text = "Wedding List:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Full Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(214, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Staff Name:";
            // 
            // txtBoxFullName
            // 
            this.txtBoxFullName.Location = new System.Drawing.Point(381, 92);
            this.txtBoxFullName.Name = "txtBoxFullName";
            this.txtBoxFullName.Size = new System.Drawing.Size(601, 26);
            this.txtBoxFullName.TabIndex = 11;
            // 
            // txtBoxStaffName
            // 
            this.txtBoxStaffName.Location = new System.Drawing.Point(381, 152);
            this.txtBoxStaffName.Name = "txtBoxStaffName";
            this.txtBoxStaffName.Size = new System.Drawing.Size(601, 26);
            this.txtBoxStaffName.TabIndex = 12;
            // 
            // cbxWeddingList
            // 
            this.cbxWeddingList.FormattingEnabled = true;
            this.cbxWeddingList.Location = new System.Drawing.Point(381, 36);
            this.cbxWeddingList.Name = "cbxWeddingList";
            this.cbxWeddingList.Size = new System.Drawing.Size(601, 28);
            this.cbxWeddingList.TabIndex = 13;
            this.cbxWeddingList.SelectedIndexChanged += new System.EventHandler(this.cbxWeddingList_SelectedIndexChanged);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(342, 785);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(0, 20);
            this.lblAmount.TabIndex = 14;
            // 
            // lblFullTotal
            // 
            this.lblFullTotal.AutoSize = true;
            this.lblFullTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullTotal.Location = new System.Drawing.Point(215, 785);
            this.lblFullTotal.Name = "lblFullTotal";
            this.lblFullTotal.Size = new System.Drawing.Size(133, 25);
            this.lblFullTotal.TabIndex = 15;
            this.lblFullTotal.Text = "Full Total:  £";
            // 
            // btnPurchaseOrder
            // 
            this.btnPurchaseOrder.Location = new System.Drawing.Point(12, 251);
            this.btnPurchaseOrder.Name = "btnPurchaseOrder";
            this.btnPurchaseOrder.Size = new System.Drawing.Size(156, 40);
            this.btnPurchaseOrder.TabIndex = 16;
            this.btnPurchaseOrder.Text = "Purchase Order";
            this.btnPurchaseOrder.UseVisualStyleBackColor = true;
            this.btnPurchaseOrder.Click += new System.EventHandler(this.btnPurchaseOrder_Click);
            // 
            // btnGenralOrder
            // 
            this.btnGenralOrder.Location = new System.Drawing.Point(12, 136);
            this.btnGenralOrder.Name = "btnGenralOrder";
            this.btnGenralOrder.Size = new System.Drawing.Size(156, 40);
            this.btnGenralOrder.TabIndex = 17;
            this.btnGenralOrder.Text = "General Order";
            this.btnGenralOrder.UseVisualStyleBackColor = true;
            this.btnGenralOrder.Click += new System.EventHandler(this.btnGenralOrder_Click);
            // 
            // CreateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 850);
            this.Controls.Add(this.btnGenralOrder);
            this.Controls.Add(this.btnPurchaseOrder);
            this.Controls.Add(this.lblFullTotal);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.cbxWeddingList);
            this.Controls.Add(this.txtBoxStaffName);
            this.Controls.Add(this.txtBoxFullName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblWedList);
            this.Controls.Add(this.btnConfirmOrder);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.lblBackgroundcolour);
            this.Controls.Add(this.dgvProduct);
            this.Name = "CreateOrder";
            this.Text = "CreateOrder";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.Label lblBackgroundcolour;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnConfirmOrder;
        private System.Windows.Forms.Label lblWedList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxFullName;
        private System.Windows.Forms.TextBox txtBoxStaffName;
        private System.Windows.Forms.ComboBox cbxWeddingList;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblFullTotal;
        private System.Windows.Forms.Button btnPurchaseOrder;
        private System.Windows.Forms.Button btnGenralOrder;
    }
}