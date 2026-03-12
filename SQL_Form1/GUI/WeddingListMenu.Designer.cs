
namespace SQL_Form1.Objects
{
    partial class WeddingListMenu
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblSimpsons = new System.Windows.Forms.Label();
            this.lblBackgroundcolour = new System.Windows.Forms.Label();
            this.btnManage = new System.Windows.Forms.Button();
            this.btnOrderProducts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(720, 225);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(295, 136);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create Wedding List";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // lblSimpsons
            // 
            this.lblSimpsons.AutoSize = true;
            this.lblSimpsons.Font = new System.Drawing.Font("Elephant", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSimpsons.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblSimpsons.Location = new System.Drawing.Point(363, 9);
            this.lblSimpsons.Name = "lblSimpsons";
            this.lblSimpsons.Size = new System.Drawing.Size(521, 123);
            this.lblSimpsons.TabIndex = 2;
            this.lblSimpsons.Text = "Simpsons";
            this.lblSimpsons.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBackgroundcolour
            // 
            this.lblBackgroundcolour.BackColor = System.Drawing.Color.DarkTurquoise;
            this.lblBackgroundcolour.Location = new System.Drawing.Point(-3, -3);
            this.lblBackgroundcolour.Name = "lblBackgroundcolour";
            this.lblBackgroundcolour.Size = new System.Drawing.Size(173, 724);
            this.lblBackgroundcolour.TabIndex = 3;
            // 
            // btnManage
            // 
            this.btnManage.Location = new System.Drawing.Point(235, 225);
            this.btnManage.Name = "btnManage";
            this.btnManage.Size = new System.Drawing.Size(305, 136);
            this.btnManage.TabIndex = 4;
            this.btnManage.Text = "Manage Wedding List";
            this.btnManage.UseVisualStyleBackColor = true;
            this.btnManage.Click += new System.EventHandler(this.btnManage_Click);
            // 
            // btnOrderProducts
            // 
            this.btnOrderProducts.Location = new System.Drawing.Point(235, 473);
            this.btnOrderProducts.Name = "btnOrderProducts";
            this.btnOrderProducts.Size = new System.Drawing.Size(305, 136);
            this.btnOrderProducts.TabIndex = 5;
            this.btnOrderProducts.Text = "Order Products";
            this.btnOrderProducts.UseVisualStyleBackColor = true;
            this.btnOrderProducts.Click += new System.EventHandler(this.btnOrderProducts_Click);
            // 
            // WeddingListMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 718);
            this.Controls.Add(this.btnOrderProducts);
            this.Controls.Add(this.btnManage);
            this.Controls.Add(this.lblBackgroundcolour);
            this.Controls.Add(this.lblSimpsons);
            this.Controls.Add(this.btnCreate);
            this.Name = "WeddingListMenu";
            this.Text = "WeddingListForm";
            this.Load += new System.EventHandler(this.WeddingListForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblSimpsons;
        private System.Windows.Forms.Label lblBackgroundcolour;
        private System.Windows.Forms.Button btnManage;
        private System.Windows.Forms.Button btnOrderProducts;
    }
}