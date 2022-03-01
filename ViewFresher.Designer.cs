namespace FreshersInfo
{
    partial class ViewFresher
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
            this.components = new System.ComponentModel.Container();
            this.listView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qualificationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fresherDetailBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.fresherDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fresherManagementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fresherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.listView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fresherDetailBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fresherDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fresherManagementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fresherBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.AllowUserToAddRows = false;
            this.listView.AutoGenerateColumns = false;
            this.listView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn,
            this.mobileNumberDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.qualificationDataGridViewTextBoxColumn});
            this.listView.DataSource = this.fresherDetailBindingSource1;
            this.listView.Location = new System.Drawing.Point(12, 12);
            this.listView.Name = "listView";
            this.listView.RowHeadersWidth = 51;
            this.listView.RowTemplate.Height = 24;
            this.listView.Size = new System.Drawing.Size(979, 433);
            this.listView.TabIndex = 0;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "NAME";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "dateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "DATE OF BIRTH";
            this.dateOfBirthDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            this.dateOfBirthDataGridViewTextBoxColumn.Width = 125;
            // 
            // mobileNumberDataGridViewTextBoxColumn
            // 
            this.mobileNumberDataGridViewTextBoxColumn.DataPropertyName = "mobileNumber";
            this.mobileNumberDataGridViewTextBoxColumn.HeaderText = "MOBILE NUMBER";
            this.mobileNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mobileNumberDataGridViewTextBoxColumn.Name = "mobileNumberDataGridViewTextBoxColumn";
            this.mobileNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "ADDRESS";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 125;
            // 
            // qualificationDataGridViewTextBoxColumn
            // 
            this.qualificationDataGridViewTextBoxColumn.DataPropertyName = "qualification";
            this.qualificationDataGridViewTextBoxColumn.HeaderText = "QUALIFICATION";
            this.qualificationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.qualificationDataGridViewTextBoxColumn.Name = "qualificationDataGridViewTextBoxColumn";
            this.qualificationDataGridViewTextBoxColumn.Width = 125;
            // 
            // fresherDetailBindingSource1
            // 
            this.fresherDetailBindingSource1.DataSource = typeof(FreshersInfo.FresherDetail);
            // 
            // update
            // 
            this.update.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.Location = new System.Drawing.Point(230, 498);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(136, 44);
            this.update.TabIndex = 1;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(529, 498);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(136, 44);
            this.delete.TabIndex = 2;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // fresherDetailBindingSource
            // 
            this.fresherDetailBindingSource.DataSource = typeof(FreshersInfo.FresherDetail);
            // 
            // fresherManagementBindingSource
            // 
            this.fresherManagementBindingSource.DataSource = typeof(FreshersInfo.FresherManagement);
            // 
            // fresherBindingSource
            // 
            this.fresherBindingSource.DataSource = typeof(FreshersInfo.Fresher);
            // 
            // ViewFresher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1015, 609);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.listView);
            this.Name = "ViewFresher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Fresher";
            ((System.ComponentModel.ISupportInitialize)(this.listView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fresherDetailBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fresherDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fresherManagementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fresherBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView listView;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.BindingSource fresherManagementBindingSource;
        private System.Windows.Forms.BindingSource fresherDetailBindingSource;
        private System.Windows.Forms.BindingSource fresherDetailBindingSource1;
        private System.Windows.Forms.BindingSource fresherBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qualificationDataGridViewTextBoxColumn;
    }
}