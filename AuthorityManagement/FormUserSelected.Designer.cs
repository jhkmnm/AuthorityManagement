namespace AuthorityManagement
{
    partial class FormUserSelected
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
            this.grpSelect = new DevExpress.XtraEditors.GroupControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.btnSearch = new System.Windows.Forms.Button();
            this.bsUserList = new System.Windows.Forms.BindingSource(this.components);
            this.grdUserList = new DevExpress.XtraGrid.GridControl();
            this.grvUserList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUserID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsSelected = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grpSelect)).BeginInit();
            this.grpSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsUserList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdUserList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvUserList)).BeginInit();
            this.SuspendLayout();
            // 
            // grpSelect
            // 
            this.grpSelect.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grpSelect.Appearance.Options.UseBackColor = true;
            this.grpSelect.Controls.Add(this.btnSearch);
            this.grpSelect.Controls.Add(this.labelControl7);
            this.grpSelect.Location = new System.Drawing.Point(4, 4);
            this.grpSelect.Name = "grpSelect";
            this.grpSelect.Size = new System.Drawing.Size(683, 65);
            this.grpSelect.TabIndex = 2;
            this.grpSelect.Text = "查询条件";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(20, 36);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(28, 14);
            this.labelControl7.TabIndex = 4;
            this.labelControl7.Text = "名称:";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Location = new System.Drawing.Point(600, 33);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // bsUserList
            // 
            this.bsUserList.DataSource = typeof(Model.View.UserVO);
            // 
            // grdUserList
            // 
            this.grdUserList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdUserList.DataSource = this.bsUserList;
            this.grdUserList.Location = new System.Drawing.Point(4, 73);
            this.grdUserList.MainView = this.grvUserList;
            this.grdUserList.Name = "grdUserList";
            this.grdUserList.Size = new System.Drawing.Size(683, 598);
            this.grdUserList.TabIndex = 3;
            this.grdUserList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvUserList});
            this.grdUserList.DoubleClick += new System.EventHandler(this.grdUserList_DoubleClick);
            // 
            // grvUserList
            // 
            this.grvUserList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIsSelected,
            this.colUserID,
            this.colUserName,
            this.colAccount});
            this.grvUserList.GridControl = this.grdUserList;
            this.grvUserList.Name = "grvUserList";
            // 
            // colUserID
            // 
            this.colUserID.FieldName = "UserID";
            this.colUserID.Name = "colUserID";
            // 
            // colUserName
            // 
            this.colUserName.Caption = "用户名";
            this.colUserName.FieldName = "UserName";
            this.colUserName.Name = "colUserName";
            this.colUserName.Visible = true;
            this.colUserName.VisibleIndex = 1;
            this.colUserName.Width = 621;
            // 
            // colAccount
            // 
            this.colAccount.FieldName = "Account";
            this.colAccount.Name = "colAccount";
            // 
            // colIsSelected
            // 
            this.colIsSelected.Caption = "选择";
            this.colIsSelected.FieldName = "IsSelected";
            this.colIsSelected.Name = "colIsSelected";
            this.colIsSelected.Visible = true;
            this.colIsSelected.VisibleIndex = 0;
            this.colIsSelected.Width = 44;
            // 
            // FormUserSelected
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 675);
            this.Controls.Add(this.grdUserList);
            this.Controls.Add(this.grpSelect);
            this.Name = "FormUserSelected";
            this.Text = "选择用户";
            ((System.ComponentModel.ISupportInitialize)(this.grpSelect)).EndInit();
            this.grpSelect.ResumeLayout(false);
            this.grpSelect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsUserList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdUserList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvUserList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grpSelect;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.BindingSource bsUserList;
        private DevExpress.XtraGrid.GridControl grdUserList;
        private DevExpress.XtraGrid.Views.Grid.GridView grvUserList;
        private DevExpress.XtraGrid.Columns.GridColumn colIsSelected;
        private DevExpress.XtraGrid.Columns.GridColumn colUserID;
        private DevExpress.XtraGrid.Columns.GridColumn colUserName;
        private DevExpress.XtraGrid.Columns.GridColumn colAccount;
    }
}