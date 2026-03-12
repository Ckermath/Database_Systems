
namespace SQL_Form1.gui
{
    partial class ExtentionTask
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
            this.txtboxprojectName = new System.Windows.Forms.TextBox();
            this.projectDataGridView = new System.Windows.Forms.DataGridView();
            this.employeesGridView = new System.Windows.Forms.DataGridView();
            this.searchbtn4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumOfEmployees = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // txtboxprojectName
            // 
            this.txtboxprojectName.Location = new System.Drawing.Point(339, 71);
            this.txtboxprojectName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxprojectName.Name = "txtboxprojectName";
            this.txtboxprojectName.Size = new System.Drawing.Size(404, 26);
            this.txtboxprojectName.TabIndex = 0;
            this.txtboxprojectName.TextChanged += new System.EventHandler(this.ProjectName_TextChanged);
            // 
            // projectDataGridView
            // 
            this.projectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.projectDataGridView.Location = new System.Drawing.Point(150, 185);
            this.projectDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.projectDataGridView.Name = "projectDataGridView";
            this.projectDataGridView.RowHeadersWidth = 62;
            this.projectDataGridView.Size = new System.Drawing.Size(897, 369);
            this.projectDataGridView.TabIndex = 2;
            this.projectDataGridView.SelectionChanged += new System.EventHandler(this.projectGridView_SelectionChanged);
            // 
            // employeesGridView
            // 
            this.employeesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeesGridView.Location = new System.Drawing.Point(150, 611);
            this.employeesGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.employeesGridView.Name = "employeesGridView";
            this.employeesGridView.RowHeadersWidth = 62;
            this.employeesGridView.Size = new System.Drawing.Size(897, 371);
            this.employeesGridView.TabIndex = 3;
            // 
            // searchbtn4
            // 
            this.searchbtn4.Location = new System.Drawing.Point(819, 51);
            this.searchbtn4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchbtn4.Name = "searchbtn4";
            this.searchbtn4.Size = new System.Drawing.Size(135, 68);
            this.searchbtn4.TabIndex = 4;
            this.searchbtn4.Text = "Search";
            this.searchbtn4.UseVisualStyleBackColor = true;
            this.searchbtn4.Click += new System.EventHandler(this.searchbtn4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter Project Name";
            // 
            // lblNumOfEmployees
            // 
            this.lblNumOfEmployees.AutoSize = true;
            this.lblNumOfEmployees.Location = new System.Drawing.Point(62, 1045);
            this.lblNumOfEmployees.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumOfEmployees.Name = "lblNumOfEmployees";
            this.lblNumOfEmployees.Size = new System.Drawing.Size(0, 20);
            this.lblNumOfEmployees.TabIndex = 6;
            // 
            // ExtentionTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 1103);
            this.Controls.Add(this.lblNumOfEmployees);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchbtn4);
            this.Controls.Add(this.employeesGridView);
            this.Controls.Add(this.projectDataGridView);
            this.Controls.Add(this.txtboxprojectName);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ExtentionTask";
            this.Text = "ExtentionTask";
            ((System.ComponentModel.ISupportInitialize)(this.projectDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxprojectName;
        private System.Windows.Forms.DataGridView projectDataGridView;
        private System.Windows.Forms.DataGridView employeesGridView;
        private System.Windows.Forms.Button searchbtn4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNumOfEmployees;
    }
}