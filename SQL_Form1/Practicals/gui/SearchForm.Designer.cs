
namespace SQL_Form1.gui
{
    partial class SearchForm
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
            this.queryCBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchBtn = new System.Windows.Forms.Button();
            this.resultsDataGrid = new System.Windows.Forms.DataGridView();
            this.resultSizeLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.projectTxtbox = new System.Windows.Forms.TextBox();
            this.btnSearch2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.resultsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // queryCBox
            // 
            this.queryCBox.FormattingEnabled = true;
            this.queryCBox.Location = new System.Drawing.Point(208, 52);
            this.queryCBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.queryCBox.Name = "queryCBox";
            this.queryCBox.Size = new System.Drawing.Size(278, 28);
            this.queryCBox.TabIndex = 0;
            this.queryCBox.SelectedIndexChanged += new System.EventHandler(this.queryCBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Query to Platform";
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(543, 52);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(212, 43);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // resultsDataGrid
            // 
            this.resultsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultsDataGrid.Location = new System.Drawing.Point(62, 165);
            this.resultsDataGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.resultsDataGrid.Name = "resultsDataGrid";
            this.resultsDataGrid.RowHeadersWidth = 62;
            this.resultsDataGrid.Size = new System.Drawing.Size(801, 363);
            this.resultsDataGrid.TabIndex = 3;
            // 
            // resultSizeLabel
            // 
            this.resultSizeLabel.AutoSize = true;
            this.resultSizeLabel.Location = new System.Drawing.Point(711, 623);
            this.resultSizeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resultSizeLabel.Name = "resultSizeLabel";
            this.resultSizeLabel.Size = new System.Drawing.Size(127, 20);
            this.resultSizeLabel.TabIndex = 4;
            this.resultSizeLabel.Text = "Result Set Size: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 623);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter Project ID:";
            // 
            // projectTxtbox
            // 
            this.projectTxtbox.Location = new System.Drawing.Point(194, 618);
            this.projectTxtbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.projectTxtbox.Name = "projectTxtbox";
            this.projectTxtbox.Size = new System.Drawing.Size(241, 26);
            this.projectTxtbox.TabIndex = 6;
            this.projectTxtbox.TextChanged += new System.EventHandler(this.projectTxtbox_TextChanged);
            // 
            // btnSearch2
            // 
            this.btnSearch2.Location = new System.Drawing.Point(495, 615);
            this.btnSearch2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch2.Name = "btnSearch2";
            this.btnSearch2.Size = new System.Drawing.Size(160, 35);
            this.btnSearch2.TabIndex = 7;
            this.btnSearch2.Text = "Search";
            this.btnSearch2.UseVisualStyleBackColor = true;
            this.btnSearch2.Click += new System.EventHandler(this.btnSearch2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 685);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Results";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 789);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 9;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(240, 789);
            this.lblResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 20);
            this.lblResult.TabIndex = 10;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 938);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSearch2);
            this.Controls.Add(this.projectTxtbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.resultSizeLabel);
            this.Controls.Add(this.resultsDataGrid);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.queryCBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resultsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox queryCBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.DataGridView resultsDataGrid;
        private System.Windows.Forms.Label resultSizeLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox projectTxtbox;
        private System.Windows.Forms.Button btnSearch2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblResult;
    }
}