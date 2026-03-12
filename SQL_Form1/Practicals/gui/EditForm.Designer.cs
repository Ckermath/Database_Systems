
namespace SQL_Form1.gui
{
    partial class EditForm
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
            this.lblSelectProjectToEdit = new System.Windows.Forms.Label();
            this.lblprojectID = new System.Windows.Forms.Label();
            this.lblprojectTitle = new System.Windows.Forms.Label();
            this.lblProjectManager = new System.Windows.Forms.Label();
            this.lblProjectBudget = new System.Windows.Forms.Label();
            this.lblProjectStartDate = new System.Windows.Forms.Label();
            this.lblProjectEndDate = new System.Windows.Forms.Label();
            this.calEndDate = new System.Windows.Forms.MonthCalendar();
            this.calStartDate = new System.Windows.Forms.MonthCalendar();
            this.ProjectCompletedCheckbox = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtProjectID = new System.Windows.Forms.TextBox();
            this.txtProjTitle = new System.Windows.Forms.TextBox();
            this.txtProjManager = new System.Windows.Forms.TextBox();
            this.txtProjBudget = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnClearData = new System.Windows.Forms.Button();
            this.errorslbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSelectProjectToEdit
            // 
            this.lblSelectProjectToEdit.AutoSize = true;
            this.lblSelectProjectToEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectProjectToEdit.Location = new System.Drawing.Point(12, 22);
            this.lblSelectProjectToEdit.Name = "lblSelectProjectToEdit";
            this.lblSelectProjectToEdit.Size = new System.Drawing.Size(207, 24);
            this.lblSelectProjectToEdit.TabIndex = 0;
            this.lblSelectProjectToEdit.Text = "Select project to edit:";
            // 
            // lblprojectID
            // 
            this.lblprojectID.AutoSize = true;
            this.lblprojectID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprojectID.Location = new System.Drawing.Point(28, 72);
            this.lblprojectID.Name = "lblprojectID";
            this.lblprojectID.Size = new System.Drawing.Size(66, 16);
            this.lblprojectID.TabIndex = 1;
            this.lblprojectID.Text = "Project ID";
            // 
            // lblprojectTitle
            // 
            this.lblprojectTitle.AutoSize = true;
            this.lblprojectTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprojectTitle.Location = new System.Drawing.Point(28, 130);
            this.lblprojectTitle.Name = "lblprojectTitle";
            this.lblprojectTitle.Size = new System.Drawing.Size(79, 16);
            this.lblprojectTitle.TabIndex = 2;
            this.lblprojectTitle.Text = "Project Title";
            // 
            // lblProjectManager
            // 
            this.lblProjectManager.AutoSize = true;
            this.lblProjectManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectManager.Location = new System.Drawing.Point(28, 189);
            this.lblProjectManager.Name = "lblProjectManager";
            this.lblProjectManager.Size = new System.Drawing.Size(107, 16);
            this.lblProjectManager.TabIndex = 3;
            this.lblProjectManager.Text = "Project Manager";
            // 
            // lblProjectBudget
            // 
            this.lblProjectBudget.AutoSize = true;
            this.lblProjectBudget.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectBudget.Location = new System.Drawing.Point(28, 247);
            this.lblProjectBudget.Name = "lblProjectBudget";
            this.lblProjectBudget.Size = new System.Drawing.Size(96, 16);
            this.lblProjectBudget.TabIndex = 4;
            this.lblProjectBudget.Text = "Project Budget";
            // 
            // lblProjectStartDate
            // 
            this.lblProjectStartDate.AutoSize = true;
            this.lblProjectStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectStartDate.Location = new System.Drawing.Point(28, 311);
            this.lblProjectStartDate.Name = "lblProjectStartDate";
            this.lblProjectStartDate.Size = new System.Drawing.Size(112, 16);
            this.lblProjectStartDate.TabIndex = 5;
            this.lblProjectStartDate.Text = "Project Start Date";
            // 
            // lblProjectEndDate
            // 
            this.lblProjectEndDate.AutoSize = true;
            this.lblProjectEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectEndDate.Location = new System.Drawing.Point(453, 311);
            this.lblProjectEndDate.Name = "lblProjectEndDate";
            this.lblProjectEndDate.Size = new System.Drawing.Size(109, 16);
            this.lblProjectEndDate.TabIndex = 6;
            this.lblProjectEndDate.Text = "Project End Date";
            // 
            // calEndDate
            // 
            this.calEndDate.Location = new System.Drawing.Point(600, 311);
            this.calEndDate.Name = "calEndDate";
            this.calEndDate.TabIndex = 7;
            // 
            // calStartDate
            // 
            this.calStartDate.Location = new System.Drawing.Point(169, 311);
            this.calStartDate.Name = "calStartDate";
            this.calStartDate.TabIndex = 8;
            // 
            // ProjectCompletedCheckbox
            // 
            this.ProjectCompletedCheckbox.AutoSize = true;
            this.ProjectCompletedCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectCompletedCheckbox.Location = new System.Drawing.Point(12, 453);
            this.ProjectCompletedCheckbox.Name = "ProjectCompletedCheckbox";
            this.ProjectCompletedCheckbox.Size = new System.Drawing.Size(145, 20);
            this.ProjectCompletedCheckbox.TabIndex = 9;
            this.ProjectCompletedCheckbox.Text = "Project Completed?";
            this.ProjectCompletedCheckbox.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(258, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(288, 21);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtProjectID
            // 
            this.txtProjectID.Enabled = false;
            this.txtProjectID.Location = new System.Drawing.Point(155, 71);
            this.txtProjectID.Name = "txtProjectID";
            this.txtProjectID.Size = new System.Drawing.Size(100, 20);
            this.txtProjectID.TabIndex = 11;
            // 
            // txtProjTitle
            // 
            this.txtProjTitle.Location = new System.Drawing.Point(155, 126);
            this.txtProjTitle.Name = "txtProjTitle";
            this.txtProjTitle.Size = new System.Drawing.Size(100, 20);
            this.txtProjTitle.TabIndex = 12;
            // 
            // txtProjManager
            // 
            this.txtProjManager.Location = new System.Drawing.Point(155, 185);
            this.txtProjManager.Name = "txtProjManager";
            this.txtProjManager.Size = new System.Drawing.Size(100, 20);
            this.txtProjManager.TabIndex = 13;
            // 
            // txtProjBudget
            // 
            this.txtProjBudget.Location = new System.Drawing.Point(155, 247);
            this.txtProjBudget.Name = "txtProjBudget";
            this.txtProjBudget.Size = new System.Drawing.Size(100, 20);
            this.txtProjBudget.TabIndex = 14;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(258, 514);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(108, 37);
            this.btnEdit.TabIndex = 15;
            this.btnEdit.Text = "Edit Project";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnClearData
            // 
            this.btnClearData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearData.Location = new System.Drawing.Point(398, 514);
            this.btnClearData.Name = "btnClearData";
            this.btnClearData.Size = new System.Drawing.Size(109, 37);
            this.btnClearData.TabIndex = 16;
            this.btnClearData.Text = "Clear Data";
            this.btnClearData.UseVisualStyleBackColor = true;
            this.btnClearData.Click += new System.EventHandler(this.btnClearData_Click);
            // 
            // errorslbl
            // 
            this.errorslbl.AutoSize = true;
            this.errorslbl.Location = new System.Drawing.Point(439, 126);
            this.errorslbl.Name = "errorslbl";
            this.errorslbl.Size = new System.Drawing.Size(0, 13);
            this.errorslbl.TabIndex = 17;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 577);
            this.Controls.Add(this.errorslbl);
            this.Controls.Add(this.btnClearData);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtProjBudget);
            this.Controls.Add(this.txtProjManager);
            this.Controls.Add(this.txtProjTitle);
            this.Controls.Add(this.txtProjectID);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ProjectCompletedCheckbox);
            this.Controls.Add(this.calStartDate);
            this.Controls.Add(this.calEndDate);
            this.Controls.Add(this.lblProjectEndDate);
            this.Controls.Add(this.lblProjectStartDate);
            this.Controls.Add(this.lblProjectBudget);
            this.Controls.Add(this.lblProjectManager);
            this.Controls.Add(this.lblprojectTitle);
            this.Controls.Add(this.lblprojectID);
            this.Controls.Add(this.lblSelectProjectToEdit);
            this.Name = "EditForm";
            this.Text = "Edit Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectProjectToEdit;
        private System.Windows.Forms.Label lblprojectID;
        private System.Windows.Forms.Label lblprojectTitle;
        private System.Windows.Forms.Label lblProjectManager;
        private System.Windows.Forms.Label lblProjectBudget;
        private System.Windows.Forms.Label lblProjectStartDate;
        private System.Windows.Forms.Label lblProjectEndDate;
        private System.Windows.Forms.MonthCalendar calEndDate;
        private System.Windows.Forms.MonthCalendar calStartDate;
        private System.Windows.Forms.CheckBox ProjectCompletedCheckbox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtProjectID;
        private System.Windows.Forms.TextBox txtProjTitle;
        private System.Windows.Forms.TextBox txtProjManager;
        private System.Windows.Forms.TextBox txtProjBudget;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnClearData;
        private System.Windows.Forms.Label errorslbl;
    }
}