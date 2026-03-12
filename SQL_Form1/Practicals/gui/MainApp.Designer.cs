
namespace SQL_Form1.gui
{
    partial class MainApp
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
            this.lblProjectManageApp = new System.Windows.Forms.Label();
            this.btnSearchTool = new System.Windows.Forms.Button();
            this.btnEditProject = new System.Windows.Forms.Button();
            this.btnAddProject = new System.Windows.Forms.Button();
            this.btnExtentionTask = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblProjectManageApp
            // 
            this.lblProjectManageApp.AutoSize = true;
            this.lblProjectManageApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectManageApp.Location = new System.Drawing.Point(283, 44);
            this.lblProjectManageApp.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblProjectManageApp.Name = "lblProjectManageApp";
            this.lblProjectManageApp.Size = new System.Drawing.Size(810, 61);
            this.lblProjectManageApp.TabIndex = 0;
            this.lblProjectManageApp.Text = "Project Management Application";
            // 
            // btnSearchTool
            // 
            this.btnSearchTool.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchTool.Location = new System.Drawing.Point(514, 202);
            this.btnSearchTool.Margin = new System.Windows.Forms.Padding(6);
            this.btnSearchTool.Name = "btnSearchTool";
            this.btnSearchTool.Size = new System.Drawing.Size(598, 110);
            this.btnSearchTool.TabIndex = 1;
            this.btnSearchTool.Text = "Search Tool";
            this.btnSearchTool.UseVisualStyleBackColor = true;
            this.btnSearchTool.Click += new System.EventHandler(this.btnSearchTool_Click);
            // 
            // btnEditProject
            // 
            this.btnEditProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditProject.Location = new System.Drawing.Point(514, 378);
            this.btnEditProject.Margin = new System.Windows.Forms.Padding(6);
            this.btnEditProject.Name = "btnEditProject";
            this.btnEditProject.Size = new System.Drawing.Size(598, 110);
            this.btnEditProject.TabIndex = 2;
            this.btnEditProject.Text = "Edit Project";
            this.btnEditProject.UseVisualStyleBackColor = true;
            this.btnEditProject.Click += new System.EventHandler(this.btnEditProject_Click);
            // 
            // btnAddProject
            // 
            this.btnAddProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProject.Location = new System.Drawing.Point(514, 565);
            this.btnAddProject.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddProject.Name = "btnAddProject";
            this.btnAddProject.Size = new System.Drawing.Size(598, 110);
            this.btnAddProject.TabIndex = 3;
            this.btnAddProject.Text = "Add Project";
            this.btnAddProject.UseVisualStyleBackColor = true;
            this.btnAddProject.Click += new System.EventHandler(this.btnAddProject_Click);
            // 
            // btnExtentionTask
            // 
            this.btnExtentionTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExtentionTask.Location = new System.Drawing.Point(514, 743);
            this.btnExtentionTask.Name = "btnExtentionTask";
            this.btnExtentionTask.Size = new System.Drawing.Size(598, 110);
            this.btnExtentionTask.TabIndex = 4;
            this.btnExtentionTask.Text = "Search by Project Name";
            this.btnExtentionTask.UseVisualStyleBackColor = true;
            this.btnExtentionTask.Click += new System.EventHandler(this.btnExtentionTask_Click);
            // 
            // MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1733, 865);
            this.Controls.Add(this.btnExtentionTask);
            this.Controls.Add(this.btnAddProject);
            this.Controls.Add(this.btnEditProject);
            this.Controls.Add(this.btnSearchTool);
            this.Controls.Add(this.lblProjectManageApp);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainApp";
            this.Text = "MainApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProjectManageApp;
        private System.Windows.Forms.Button btnSearchTool;
        private System.Windows.Forms.Button btnEditProject;
        private System.Windows.Forms.Button btnAddProject;
        private System.Windows.Forms.Button btnExtentionTask;
    }
}