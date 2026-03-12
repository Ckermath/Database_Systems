
namespace SQL_Form1.GUI
{
    partial class ManageWeddingListForm
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
            this.WeddingListDataGridView = new System.Windows.Forms.DataGridView();
            this.lblBackgroundcolour = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxSearchForWL = new System.Windows.Forms.TextBox();
            this.btnEditWeddingList = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblWeddingListDetails = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.comboBoxProduct = new System.Windows.Forms.ComboBox();
            this.txtboxQty = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblFullname = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.WeddingListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // WeddingListDataGridView
            // 
            this.WeddingListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WeddingListDataGridView.Location = new System.Drawing.Point(243, 500);
            this.WeddingListDataGridView.Name = "WeddingListDataGridView";
            this.WeddingListDataGridView.RowHeadersWidth = 62;
            this.WeddingListDataGridView.RowTemplate.Height = 28;
            this.WeddingListDataGridView.Size = new System.Drawing.Size(1351, 428);
            this.WeddingListDataGridView.TabIndex = 9;
            this.WeddingListDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.WeddingListDataGridView_CellContentClick);
            // 
            // lblBackgroundcolour
            // 
            this.lblBackgroundcolour.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblBackgroundcolour.Location = new System.Drawing.Point(-9, -2);
            this.lblBackgroundcolour.Name = "lblBackgroundcolour";
            this.lblBackgroundcolour.Size = new System.Drawing.Size(173, 1031);
            this.lblBackgroundcolour.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(672, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 40);
            this.label1.TabIndex = 7;
            this.label1.Text = "Search For Wedding List";
            // 
            // txtBoxSearchForWL
            // 
            this.txtBoxSearchForWL.Location = new System.Drawing.Point(661, 57);
            this.txtBoxSearchForWL.Name = "txtBoxSearchForWL";
            this.txtBoxSearchForWL.Size = new System.Drawing.Size(435, 26);
            this.txtBoxSearchForWL.TabIndex = 6;
            // 
            // btnEditWeddingList
            // 
            this.btnEditWeddingList.Location = new System.Drawing.Point(12, 87);
            this.btnEditWeddingList.Name = "btnEditWeddingList";
            this.btnEditWeddingList.Size = new System.Drawing.Size(140, 72);
            this.btnEditWeddingList.TabIndex = 12;
            this.btnEditWeddingList.Text = "Edit Wedding List";
            this.btnEditWeddingList.UseVisualStyleBackColor = true;
            this.btnEditWeddingList.Visible = false;
            this.btnEditWeddingList.Click += new System.EventHandler(this.btnEditWeddingList_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1131, 57);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(159, 35);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblWeddingListDetails
            // 
            this.lblWeddingListDetails.AutoSize = true;
            this.lblWeddingListDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeddingListDetails.Location = new System.Drawing.Point(719, 103);
            this.lblWeddingListDetails.Name = "lblWeddingListDetails";
            this.lblWeddingListDetails.Size = new System.Drawing.Size(0, 32);
            this.lblWeddingListDetails.TabIndex = 14;
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(12, 30);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(140, 37);
            this.btnMenu.TabIndex = 15;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // comboBoxProduct
            // 
            this.comboBoxProduct.FormattingEnabled = true;
            this.comboBoxProduct.Location = new System.Drawing.Point(391, 442);
            this.comboBoxProduct.Name = "comboBoxProduct";
            this.comboBoxProduct.Size = new System.Drawing.Size(245, 28);
            this.comboBoxProduct.TabIndex = 17;
            // 
            // txtboxQty
            // 
            this.txtboxQty.Location = new System.Drawing.Point(865, 442);
            this.txtboxQty.Name = "txtboxQty";
            this.txtboxQty.Size = new System.Drawing.Size(205, 26);
            this.txtboxQty.TabIndex = 18;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(1235, 435);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(134, 40);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(12, 692);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(140, 55);
            this.btnRefresh.TabIndex = 20;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.Location = new System.Drawing.Point(741, 441);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(106, 29);
            this.lblQty.TabIndex = 22;
            this.lblQty.Text = "Quantity:";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.Location = new System.Drawing.Point(259, 442);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(102, 29);
            this.lblProduct.TabIndex = 23;
            this.lblProduct.Text = "Product:";
            // 
            // lblFullname
            // 
            this.lblFullname.AutoSize = true;
            this.lblFullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullname.Location = new System.Drawing.Point(512, 53);
            this.lblFullname.Name = "lblFullname";
            this.lblFullname.Size = new System.Drawing.Size(130, 29);
            this.lblFullname.TabIndex = 24;
            this.lblFullname.Text = "Full Name:";
            // 
            // ManageWeddingListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1670, 1067);
            this.Controls.Add(this.lblFullname);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtboxQty);
            this.Controls.Add(this.comboBoxProduct);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.lblWeddingListDetails);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnEditWeddingList);
            this.Controls.Add(this.WeddingListDataGridView);
            this.Controls.Add(this.lblBackgroundcolour);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxSearchForWL);
            this.Name = "ManageWeddingListForm";
            this.Text = "ManageWeddingListForm";
            ((System.ComponentModel.ISupportInitialize)(this.WeddingListDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView WeddingListDataGridView;
        private System.Windows.Forms.Label lblBackgroundcolour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxSearchForWL;
        private System.Windows.Forms.Button btnEditWeddingList;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblWeddingListDetails;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.ComboBox comboBoxProduct;
        private System.Windows.Forms.TextBox txtboxQty;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblFullname;
    }
}