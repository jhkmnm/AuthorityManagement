namespace AuthorityManagement
{
    partial class FormSystemManage
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
            this.grdSystem = new DevExpress.XtraGrid.GridControl();
            this.bsSystemList = new System.Windows.Forms.BindingSource(this.components);
            this.grvSystem = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSystemID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSystemName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSystemDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grpSystem = new DevExpress.XtraEditors.GroupControl();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtDescription = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtSystemName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdSystem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSystemList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvSystem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpSystem)).BeginInit();
            this.grpSystem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSystemName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grdSystem
            // 
            this.grdSystem.DataSource = this.bsSystemList;
            this.grdSystem.Location = new System.Drawing.Point(2, 2);
            this.grdSystem.MainView = this.grvSystem;
            this.grdSystem.Name = "grdSystem";
            this.grdSystem.Size = new System.Drawing.Size(400, 413);
            this.grdSystem.TabIndex = 0;
            this.grdSystem.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvSystem});
            // 
            // bsSystemList
            // 
            this.bsSystemList.DataSource = typeof(Model.View.SystemVO);
            // 
            // grvSystem
            // 
            this.grvSystem.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSystemID,
            this.colSystemName,
            this.colSystemDescription});
            this.grvSystem.GridControl = this.grdSystem;
            this.grvSystem.Name = "grvSystem";
            this.grvSystem.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.grvSystem_RowClick);
            // 
            // colSystemID
            // 
            this.colSystemID.Caption = "系统ID";
            this.colSystemID.FieldName = "SystemID";
            this.colSystemID.Name = "colSystemID";
            this.colSystemID.OptionsColumn.AllowEdit = false;
            this.colSystemID.Visible = true;
            this.colSystemID.VisibleIndex = 0;
            this.colSystemID.Width = 61;
            // 
            // colSystemName
            // 
            this.colSystemName.Caption = "系统名称";
            this.colSystemName.FieldName = "SystemName";
            this.colSystemName.Name = "colSystemName";
            this.colSystemName.OptionsColumn.AllowEdit = false;
            this.colSystemName.Visible = true;
            this.colSystemName.VisibleIndex = 1;
            this.colSystemName.Width = 159;
            // 
            // colSystemDescription
            // 
            this.colSystemDescription.Caption = "系统描述";
            this.colSystemDescription.FieldName = "SystemDescription";
            this.colSystemDescription.Name = "colSystemDescription";
            this.colSystemDescription.OptionsColumn.AllowEdit = false;
            this.colSystemDescription.Visible = true;
            this.colSystemDescription.VisibleIndex = 2;
            this.colSystemDescription.Width = 162;
            // 
            // grpSystem
            // 
            this.grpSystem.Controls.Add(this.btnSave);
            this.grpSystem.Controls.Add(this.txtDescription);
            this.grpSystem.Controls.Add(this.labelControl2);
            this.grpSystem.Controls.Add(this.txtSystemName);
            this.grpSystem.Controls.Add(this.labelControl1);
            this.grpSystem.Location = new System.Drawing.Point(406, 43);
            this.grpSystem.Name = "grpSystem";
            this.grpSystem.ShowCaption = false;
            this.grpSystem.Size = new System.Drawing.Size(325, 188);
            this.grpSystem.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Location = new System.Drawing.Point(242, 156);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(71, 41);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Properties.AutoHeight = false;
            this.txtDescription.Size = new System.Drawing.Size(246, 109);
            this.txtDescription.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(13, 44);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(52, 14);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "系统描述:";
            // 
            // txtSystemName
            // 
            this.txtSystemName.Location = new System.Drawing.Point(71, 11);
            this.txtSystemName.Name = "txtSystemName";
            this.txtSystemName.Size = new System.Drawing.Size(246, 20);
            this.txtSystemName.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 14);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "系统名称:";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Location = new System.Drawing.Point(533, 8);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Location = new System.Drawing.Point(412, 8);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "新建";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FormSystemManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 417);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grpSystem);
            this.Controls.Add(this.grdSystem);
            this.Name = "FormSystemManage";
            this.Text = "系统类型配置";
            ((System.ComponentModel.ISupportInitialize)(this.grdSystem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSystemList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvSystem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpSystem)).EndInit();
            this.grpSystem.ResumeLayout(false);
            this.grpSystem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSystemName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdSystem;
        private DevExpress.XtraGrid.Views.Grid.GridView grvSystem;
        private DevExpress.XtraGrid.Columns.GridColumn colSystemID;
        private DevExpress.XtraGrid.Columns.GridColumn colSystemName;
        private DevExpress.XtraGrid.Columns.GridColumn colSystemDescription;
        private DevExpress.XtraEditors.GroupControl grpSystem;
        private System.Windows.Forms.Button btnSave;
        private DevExpress.XtraEditors.TextEdit txtDescription;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtSystemName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.BindingSource bsSystemList;
    }
}