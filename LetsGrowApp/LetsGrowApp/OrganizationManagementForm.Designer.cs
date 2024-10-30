﻿namespace LetsGrowApp
{
    partial class OrganizationManagementForm
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

        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblContactInfo = new System.Windows.Forms.Label();
            this.txtContactInfo = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnAddOrganization = new System.Windows.Forms.Button();
            this.btnEditOrganization = new System.Windows.Forms.Button();
            this.btnDeleteOrganization = new System.Windows.Forms.Button();
            this.dataGridViewOrganizations = new System.Windows.Forms.DataGridView();
            this.btnBackToMain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrganizations)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(34, 38);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(138, 35);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(150, 20);
            this.txtName.TabIndex = 1;
            // 
            // lblContactInfo
            // 
            this.lblContactInfo.AutoSize = true;
            this.lblContactInfo.Location = new System.Drawing.Point(34, 82);
            this.lblContactInfo.Name = "lblContactInfo";
            this.lblContactInfo.Size = new System.Drawing.Size(68, 13);
            this.lblContactInfo.TabIndex = 2;
            this.lblContactInfo.Text = "Contact Info:";
            // 
            // txtContactInfo
            // 
            this.txtContactInfo.Location = new System.Drawing.Point(138, 79);
            this.txtContactInfo.Name = "txtContactInfo";
            this.txtContactInfo.Size = new System.Drawing.Size(150, 20);
            this.txtContactInfo.TabIndex = 3;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(34, 126);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "Description:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(138, 123);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(150, 20);
            this.txtDescription.TabIndex = 5;
            // 
            // btnAddOrganization
            // 
            this.btnAddOrganization.Location = new System.Drawing.Point(34, 162);
            this.btnAddOrganization.Name = "btnAddOrganization";
            this.btnAddOrganization.Size = new System.Drawing.Size(75, 23);
            this.btnAddOrganization.TabIndex = 6;
            this.btnAddOrganization.Text = "Add Org";
            this.btnAddOrganization.UseVisualStyleBackColor = true;
            this.btnAddOrganization.Click += new System.EventHandler(this.btnAddOrganization_Click);
            // 
            // btnEditOrganization
            // 
            this.btnEditOrganization.Location = new System.Drawing.Point(138, 162);
            this.btnEditOrganization.Name = "btnEditOrganization";
            this.btnEditOrganization.Size = new System.Drawing.Size(75, 23);
            this.btnEditOrganization.TabIndex = 7;
            this.btnEditOrganization.Text = "Edit Org";
            this.btnEditOrganization.UseVisualStyleBackColor = true;
            this.btnEditOrganization.Click += new System.EventHandler(this.btnEditOrganization_Click);
            // 
            // btnDeleteOrganization
            // 
            this.btnDeleteOrganization.Location = new System.Drawing.Point(243, 162);
            this.btnDeleteOrganization.Name = "btnDeleteOrganization";
            this.btnDeleteOrganization.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteOrganization.TabIndex = 8;
            this.btnDeleteOrganization.Text = "Delete Org";
            this.btnDeleteOrganization.UseVisualStyleBackColor = true;
            this.btnDeleteOrganization.Click += new System.EventHandler(this.btnDeleteOrganization_Click);
            // 
            // dataGridViewOrganizations
            // 
            this.dataGridViewOrganizations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrganizations.Location = new System.Drawing.Point(34, 200);
            this.dataGridViewOrganizations.Name = "dataGridViewOrganizations";
            this.dataGridViewOrganizations.Size = new System.Drawing.Size(284, 150);
            this.dataGridViewOrganizations.TabIndex = 9;
            // 
            // btnBackToMain
            // 
            this.btnBackToMain.Location = new System.Drawing.Point(34, 370);
            this.btnBackToMain.Name = "btnBackToMain";
            this.btnBackToMain.Size = new System.Drawing.Size(75, 23);
            this.btnBackToMain.TabIndex = 10;
            this.btnBackToMain.Text = "Back";
            this.btnBackToMain.UseVisualStyleBackColor = true;
            this.btnBackToMain.Click += new System.EventHandler(this.btnBackToMain_Click);
            // 
            // OrganizationManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 458);
            this.Controls.Add(this.btnBackToMain);
            this.Controls.Add(this.dataGridViewOrganizations);
            this.Controls.Add(this.btnDeleteOrganization);
            this.Controls.Add(this.btnEditOrganization);
            this.Controls.Add(this.btnAddOrganization);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtContactInfo);
            this.Controls.Add(this.lblContactInfo);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "OrganizationManagementForm";
            this.Text = "Manage Organizations";
            this.Load += new System.EventHandler(this.OrganizationsManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrganizations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblContactInfo;
        private System.Windows.Forms.TextBox txtContactInfo;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnAddOrganization;
        private System.Windows.Forms.Button btnEditOrganization;
        private System.Windows.Forms.Button btnDeleteOrganization;
        private System.Windows.Forms.DataGridView dataGridViewOrganizations;
        private System.Windows.Forms.Button btnBackToMain;
    }
}
