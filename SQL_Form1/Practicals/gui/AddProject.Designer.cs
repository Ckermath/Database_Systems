
namespace SQL_Form1.gui
{
    partial class AddProject
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
            this.lblprojectTitle = new System.Windows.Forms.Label();
            this.lblProjectManager = new System.Windows.Forms.Label();
            this.lblProjectBudget = new System.Windows.Forms.Label();
            this.lblProjectStartDate = new System.Windows.Forms.Label();
            this.lblProjectEndDate = new System.Windows.Forms.Label();
            this.calEndDate = new System.Windows.Forms.MonthCalendar();
            this.calStartDate = new System.Windows.Forms.MonthCalendar();
            this.ProjectCompletedCheckbox = new System.Windows.Forms.CheckBox();
            this.txtProjTitle = new System.Windows.Forms.TextBox();
            this.txtProjManager = new System.Windows.Forms.TextBox();
            this.txtProjBudget = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClearData = new System.Windows.Forms.Button();
            this.errorslbl = new System.Windows.Forms.Label();
            this.lboxAvailableEmployees = new System.Windows.Forms.ListBox();
            this.lboxSelectedEmployees = new System.Windows.Forms.ListBox();
            this.btnSelected = new System.Windows.Forms.Button();
            this.btnDeselect = new System.Windows.Forms.Button();
            this.lblAvailableEmployees = new System.Windows.Forms.Label();
            this.lblSelectedEmployees = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblprojectTitle
            // 
            this.lblprojectTitle.AutoSize = true;
            this.lblprojectTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprojectTitle.Location = new System.Drawing.Point(51, 80);
            this.lblprojectTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblprojectTitle.Name = "lblprojectTitle";
            this.lblprojectTitle.Size = new System.Drawing.Size(114, 25);
            this.lblprojectTitle.TabIndex = 2;
            this.lblprojectTitle.Text = "Project Title";
            // 
            // lblProjectManager
            // 
            this.lblProjectManager.AutoSize = true;
            this.lblProjectManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectManager.Location = new System.Drawing.Point(51, 158);
            this.lblProjectManager.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProjectManager.Name = "lblProjectManager";
            this.lblProjectManager.Size = new System.Drawing.Size(155, 25);
            this.lblProjectManager.TabIndex = 3;
            this.lblProjectManager.Text = "Project Manager";
            // 
            // lblProjectBudget
            // 
            this.lblProjectBudget.AutoSize = true;
            this.lblProjectBudget.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectBudget.Location = new System.Drawing.Point(51, 246);
            this.lblProjectBudget.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProjectBudget.Name = "lblProjectBudget";
            this.lblProjectBudget.Size = new System.Drawing.Size(139, 25);
            this.lblProjectBudget.TabIndex = 4;
            this.lblProjectBudget.Text = "Project Budget";
            // 
            // lblProjectStartDate
            // 
            this.lblProjectStartDate.AutoSize = true;
            this.lblProjectStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectStartDate.Location = new System.Drawing.Point(650, 9);
            this.lblProjectStartDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProjectStartDate.Name = "lblProjectStartDate";
            this.lblProjectStartDate.Size = new System.Drawing.Size(164, 25);
            this.lblProjectStartDate.TabIndex = 5;
            this.lblProjectStartDate.Text = "Project Start Date";
            // 
            // lblProjectEndDate
            // 
            this.lblProjectEndDate.AutoSize = true;
            this.lblProjectEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectEndDate.Location = new System.Drawing.Point(1036, 9);
            this.lblProjectEndDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProjectEndDate.Name = "lblProjectEndDate";
            this.lblProjectEndDate.Size = new System.Drawing.Size(158, 25);
            this.lblProjectEndDate.TabIndex = 6;
            this.lblProjectEndDate.Text = "Project End Date";
            // 
            // calEndDate
            // 
            this.calEndDate.Location = new System.Drawing.Point(959, 44);
            this.calEndDate.Margin = new System.Windows.Forms.Padding(14);
            this.calEndDate.Name = "calEndDate";
            this.calEndDate.TabIndex = 7;
            // 
            // calStartDate
            // 
            this.calStartDate.Location = new System.Drawing.Point(581, 44);
            this.calStartDate.Margin = new System.Windows.Forms.Padding(14);
            this.calStartDate.Name = "calStartDate";
            this.calStartDate.TabIndex = 8;
            // 
            // ProjectCompletedCheckbox
            // 
            this.ProjectCompletedCheckbox.AutoSize = true;
            this.ProjectCompletedCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectCompletedCheckbox.Location = new System.Drawing.Point(56, 316);
            this.ProjectCompletedCheckbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProjectCompletedCheckbox.Name = "ProjectCompletedCheckbox";
            this.ProjectCompletedCheckbox.Size = new System.Drawing.Size(209, 29);
            this.ProjectCompletedCheckbox.TabIndex = 9;
            this.ProjectCompletedCheckbox.Text = "Project Completed?";
            this.ProjectCompletedCheckbox.UseVisualStyleBackColor = true;
            // 
            // txtProjTitle
            // 
            this.txtProjTitle.Location = new System.Drawing.Point(232, 81);
            this.txtProjTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtProjTitle.Name = "txtProjTitle";
            this.txtProjTitle.Size = new System.Drawing.Size(148, 26);
            this.txtProjTitle.TabIndex = 12;
            // 
            // txtProjManager
            // 
            this.txtProjManager.Location = new System.Drawing.Point(232, 158);
            this.txtProjManager.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtProjManager.Name = "txtProjManager";
            this.txtProjManager.Size = new System.Drawing.Size(148, 26);
            this.txtProjManager.TabIndex = 13;
            // 
            // txtProjBudget
            // 
            this.txtProjBudget.Location = new System.Drawing.Point(232, 247);
            this.txtProjBudget.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtProjBudget.Name = "txtProjBudget";
            this.txtProjBudget.Size = new System.Drawing.Size(148, 26);
            this.txtProjBudget.TabIndex = 14;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(747, 742);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(162, 57);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add Project";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClearData
            // 
            this.btnClearData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearData.Location = new System.Drawing.Point(959, 742);
            this.btnClearData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClearData.Name = "btnClearData";
            this.btnClearData.Size = new System.Drawing.Size(164, 57);
            this.btnClearData.TabIndex = 16;
            this.btnClearData.Text = "Clear Data";
            this.btnClearData.UseVisualStyleBackColor = true;
            this.btnClearData.Click += new System.EventHandler(this.btnClearData_Click);
            // 
            // errorslbl
            // 
            this.errorslbl.AutoSize = true;
            this.errorslbl.Location = new System.Drawing.Point(764, 480);
            this.errorslbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errorslbl.Name = "errorslbl";
            this.errorslbl.Size = new System.Drawing.Size(0, 20);
            this.errorslbl.TabIndex = 17;
            // 
            // lboxAvailableEmployees
            // 
            this.lboxAvailableEmployees.FormattingEnabled = true;
            this.lboxAvailableEmployees.ItemHeight = 20;
            this.lboxAvailableEmployees.Location = new System.Drawing.Point(41, 415);
            this.lboxAvailableEmployees.Name = "lboxAvailableEmployees";
            this.lboxAvailableEmployees.Size = new System.Drawing.Size(290, 244);
            this.lboxAvailableEmployees.TabIndex = 18;
            // 
            // lboxSelectedEmployees
            // 
            this.lboxSelectedEmployees.FormattingEnabled = true;
            this.lboxSelectedEmployees.ItemHeight = 20;
            this.lboxSelectedEmployees.Location = new System.Drawing.Point(447, 415);
            this.lboxSelectedEmployees.Name = "lboxSelectedEmployees";
            this.lboxSelectedEmployees.Size = new System.Drawing.Size(298, 244);
            this.lboxSelectedEmployees.TabIndex = 19;
            // 
            // btnSelected
            // 
            this.btnSelected.Location = new System.Drawing.Point(367, 464);
            this.btnSelected.Name = "btnSelected";
            this.btnSelected.Size = new System.Drawing.Size(53, 52);
            this.btnSelected.TabIndex = 21;
            this.btnSelected.Text = ">";
            this.btnSelected.UseVisualStyleBackColor = true;
            this.btnSelected.Click += new System.EventHandler(this.btnSelected_Click);
            // 
            // btnDeselect
            // 
            this.btnDeselect.Location = new System.Drawing.Point(367, 569);
            this.btnDeselect.Name = "btnDeselect";
            this.btnDeselect.Size = new System.Drawing.Size(53, 51);
            this.btnDeselect.TabIndex = 22;
            this.btnDeselect.Text = "<";
            this.btnDeselect.UseVisualStyleBackColor = true;
            this.btnDeselect.Click += new System.EventHandler(this.btnDeselect_Click);
            // 
            // lblAvailableEmployees
            // 
            this.lblAvailableEmployees.AutoSize = true;
            this.lblAvailableEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableEmployees.Location = new System.Drawing.Point(71, 367);
            this.lblAvailableEmployees.Name = "lblAvailableEmployees";
            this.lblAvailableEmployees.Size = new System.Drawing.Size(194, 25);
            this.lblAvailableEmployees.TabIndex = 23;
            this.lblAvailableEmployees.Text = "Available Employees";
            // 
            // lblSelectedEmployees
            // 
            this.lblSelectedEmployees.AutoSize = true;
            this.lblSelectedEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedEmployees.Location = new System.Drawing.Point(506, 367);
            this.lblSelectedEmployees.Name = "lblSelectedEmployees";
            this.lblSelectedEmployees.Size = new System.Drawing.Size(191, 25);
            this.lblSelectedEmployees.TabIndex = 24;
            this.lblSelectedEmployees.Text = "Selected Employees";
            // 
            // AddProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 888);
            this.Controls.Add(this.lblSelectedEmployees);
            this.Controls.Add(this.lblAvailableEmployees);
            this.Controls.Add(this.btnDeselect);
            this.Controls.Add(this.btnSelected);
            this.Controls.Add(this.lboxSelectedEmployees);
            this.Controls.Add(this.lboxAvailableEmployees);
            this.Controls.Add(this.errorslbl);
            this.Controls.Add(this.btnClearData);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtProjBudget);
            this.Controls.Add(this.txtProjManager);
            this.Controls.Add(this.txtProjTitle);
            this.Controls.Add(this.ProjectCompletedCheckbox);
            this.Controls.Add(this.calStartDate);
            this.Controls.Add(this.calEndDate);
            this.Controls.Add(this.lblProjectEndDate);
            this.Controls.Add(this.lblProjectStartDate);
            this.Controls.Add(this.lblProjectBudget);
            this.Controls.Add(this.lblProjectManager);
            this.Controls.Add(this.lblprojectTitle);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddProject";
            this.Text = "Add Form";
            this.Load += new System.EventHandler(this.AddProject_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblprojectTitle;
        private System.Windows.Forms.Label lblProjectManager;
        private System.Windows.Forms.Label lblProjectBudget;
        private System.Windows.Forms.Label lblProjectStartDate;
        private System.Windows.Forms.Label lblProjectEndDate;
        private System.Windows.Forms.MonthCalendar calEndDate;
        private System.Windows.Forms.MonthCalendar calStartDate;
        private System.Windows.Forms.CheckBox ProjectCompletedCheckbox;
        private System.Windows.Forms.TextBox txtProjTitle;
        private System.Windows.Forms.TextBox txtProjManager;
        private System.Windows.Forms.TextBox txtProjBudget;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClearData;
        private System.Windows.Forms.Label errorslbl;
        private System.Windows.Forms.ListBox lboxAvailableEmployees;
        private System.Windows.Forms.ListBox lboxSelectedEmployees;
        private System.Windows.Forms.Button btnSelected;
        private System.Windows.Forms.Button btnDeselect;
        private System.Windows.Forms.Label lblAvailableEmployees;
        private System.Windows.Forms.Label lblSelectedEmployees;
    }
}