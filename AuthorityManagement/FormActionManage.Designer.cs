namespace AuthorityManagement
{
    partial class FormActionManage
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
            this.ddlSystem = new System.Windows.Forms.ComboBox();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtMenuName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.bsMenuActionList = new System.Windows.Forms.BindingSource(this.components);
            this.colName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colIndex = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colIsValid = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.grpMenuAction = new DevExpress.XtraEditors.GroupControl();
            this.treeMenuList = new DevExpress.XtraTreeList.TreeList();
            this.colKeyID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colMenuActiveName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colIsVisible = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colPath = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grpEdit = new DevExpress.XtraEditors.GroupControl();
            this.txtActionCode = new DevExpress.XtraEditors.TextEdit();
            this.bsActionEdit = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.ddlParent = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtPath = new DevExpress.XtraEditors.TextEdit();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.grpSelect)).BeginInit();
            this.grpSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMenuName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMenuActionList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpMenuAction)).BeginInit();
            this.grpMenuAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeMenuList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpEdit)).BeginInit();
            this.grpEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtActionCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsActionEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grpSelect
            // 
            this.grpSelect.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grpSelect.Appearance.Options.UseBackColor = true;
            this.grpSelect.Controls.Add(this.ddlSystem);
            this.grpSelect.Controls.Add(this.labelControl7);
            this.grpSelect.Controls.Add(this.btnSearch);
            this.grpSelect.Controls.Add(this.txtMenuName);
            this.grpSelect.Controls.Add(this.labelControl1);
            this.grpSelect.Location = new System.Drawing.Point(2, 2);
            this.grpSelect.Name = "grpSelect";
            this.grpSelect.ShowCaption = false;
            this.grpSelect.Size = new System.Drawing.Size(963, 51);
            this.grpSelect.TabIndex = 1;
            // 
            // ddlSystem
            // 
            this.ddlSystem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlSystem.FormattingEnabled = true;
            this.ddlSystem.Location = new System.Drawing.Point(90, 18);
            this.ddlSystem.Name = "ddlSystem";
            this.ddlSystem.Size = new System.Drawing.Size(187, 20);
            this.ddlSystem.TabIndex = 12;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(32, 20);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(52, 14);
            this.labelControl7.TabIndex = 3;
            this.labelControl7.Text = "所属系统:";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Location = new System.Drawing.Point(825, 14);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtMenuName
            // 
            this.txtMenuName.Location = new System.Drawing.Point(407, 17);
            this.txtMenuName.Name = "txtMenuName";
            this.txtMenuName.Size = new System.Drawing.Size(294, 20);
            this.txtMenuName.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(349, 20);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "菜单名称:";
            // 
            // bsMenuActionList
            // 
            this.bsMenuActionList.DataSource = typeof(Model.View.MenuActionVO);
            // 
            // colName
            // 
            this.colName.Caption = "显示名称";
            this.colName.FieldName = "MenuName";
            this.colName.Name = "colName";
            this.colName.OptionsColumn.AllowEdit = false;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 101;
            // 
            // colIndex
            // 
            this.colIndex.Caption = "排序";
            this.colIndex.FieldName = "VisibleIndex";
            this.colIndex.Name = "colIndex";
            this.colIndex.OptionsColumn.AllowEdit = false;
            this.colIndex.Visible = true;
            this.colIndex.VisibleIndex = 1;
            this.colIndex.Width = 43;
            // 
            // colIsValid
            // 
            this.colIsValid.Caption = "菜单可见";
            this.colIsValid.FieldName = "IsVisible";
            this.colIsValid.Name = "colIsValid";
            this.colIsValid.OptionsColumn.AllowEdit = false;
            this.colIsValid.Visible = true;
            this.colIsValid.VisibleIndex = 2;
            this.colIsValid.Width = 31;
            // 
            // grpMenuAction
            // 
            this.grpMenuAction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grpMenuAction.Controls.Add(this.treeMenuList);
            this.grpMenuAction.Location = new System.Drawing.Point(2, 57);
            this.grpMenuAction.Name = "grpMenuAction";
            this.grpMenuAction.Size = new System.Drawing.Size(433, 641);
            this.grpMenuAction.TabIndex = 3;
            this.grpMenuAction.Text = "菜单、功能列表";
            // 
            // treeMenuList
            // 
            this.treeMenuList.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colKeyID,
            this.colMenuActiveName,
            this.colIsVisible,
            this.colPath});
            this.treeMenuList.DataSource = this.bsMenuActionList;
            this.treeMenuList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeMenuList.Location = new System.Drawing.Point(2, 22);
            this.treeMenuList.Name = "treeMenuList";
            this.treeMenuList.OptionsView.ShowAutoFilterRow = true;
            this.treeMenuList.Size = new System.Drawing.Size(429, 617);
            this.treeMenuList.TabIndex = 2;
            // 
            // colKeyID
            // 
            this.colKeyID.FieldName = "KeyID";
            this.colKeyID.Name = "colKeyID";
            this.colKeyID.Width = 25;
            // 
            // colMenuActiveName
            // 
            this.colMenuActiveName.Caption = "名称";
            this.colMenuActiveName.FieldName = "MenuActiveName";
            this.colMenuActiveName.Name = "colMenuActiveName";
            this.colMenuActiveName.Visible = true;
            this.colMenuActiveName.VisibleIndex = 0;
            this.colMenuActiveName.Width = 198;
            // 
            // colIsVisible
            // 
            this.colIsVisible.Caption = "显示";
            this.colIsVisible.FieldName = "IsVisible";
            this.colIsVisible.Name = "colIsVisible";
            this.colIsVisible.Visible = true;
            this.colIsVisible.VisibleIndex = 1;
            this.colIsVisible.Width = 36;
            // 
            // colPath
            // 
            this.colPath.Caption = "路径";
            this.colPath.FieldName = "Path";
            this.colPath.Name = "colPath";
            this.colPath.Visible = true;
            this.colPath.VisibleIndex = 2;
            this.colPath.Width = 177;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Location = new System.Drawing.Point(573, 79);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Location = new System.Drawing.Point(452, 79);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "新建";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grpEdit
            // 
            this.grpEdit.Controls.Add(this.txtActionCode);
            this.grpEdit.Controls.Add(this.labelControl8);
            this.grpEdit.Controls.Add(this.ddlParent);
            this.grpEdit.Controls.Add(this.btnSave);
            this.grpEdit.Controls.Add(this.txtPath);
            this.grpEdit.Controls.Add(this.txtName);
            this.grpEdit.Controls.Add(this.labelControl5);
            this.grpEdit.Controls.Add(this.labelControl3);
            this.grpEdit.Controls.Add(this.labelControl2);
            this.grpEdit.Location = new System.Drawing.Point(441, 119);
            this.grpEdit.Name = "grpEdit";
            this.grpEdit.Size = new System.Drawing.Size(524, 185);
            this.grpEdit.TabIndex = 5;
            this.grpEdit.Text = "编辑功能";
            // 
            // txtActionCode
            // 
            this.txtActionCode.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsActionEdit, "ActionCode", true));
            this.txtActionCode.Location = new System.Drawing.Point(117, 93);
            this.txtActionCode.Name = "txtActionCode";
            this.txtActionCode.Size = new System.Drawing.Size(145, 20);
            this.txtActionCode.TabIndex = 13;
            this.txtActionCode.ToolTip = "名称不能为空";
            // 
            // bsActionEdit
            // 
            this.bsActionEdit.DataSource = typeof(Model.View.ActionVO);
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(22, 96);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(65, 14);
            this.labelControl8.TabIndex = 12;
            this.labelControl8.Text = "功能编码(*)";
            // 
            // ddlParent
            // 
            this.ddlParent.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsActionEdit, "MenuID", true));
            this.ddlParent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlParent.FormattingEnabled = true;
            this.ddlParent.Location = new System.Drawing.Point(117, 32);
            this.ddlParent.Name = "ddlParent";
            this.ddlParent.Size = new System.Drawing.Size(399, 20);
            this.ddlParent.TabIndex = 11;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Location = new System.Drawing.Point(441, 152);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPath
            // 
            this.txtPath.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsActionEdit, "ActionPath", true));
            this.txtPath.Location = new System.Drawing.Point(117, 123);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(399, 20);
            this.txtPath.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsActionEdit, "ActionName", true));
            this.txtName.Location = new System.Drawing.Point(117, 63);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(145, 20);
            this.txtName.TabIndex = 4;
            this.txtName.ToolTip = "名称不能为空";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(22, 126);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(48, 14);
            this.labelControl5.TabIndex = 3;
            this.labelControl5.Text = "访问路径";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(22, 34);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(65, 14);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "上级菜单(*)";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(22, 66);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(65, 14);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "显示名称(*)";
            // 
            // FormActionManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 702);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.grpEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grpMenuAction);
            this.Controls.Add(this.grpSelect);
            this.Name = "FormActionManage";
            this.Text = "功能管理";
            ((System.ComponentModel.ISupportInitialize)(this.grpSelect)).EndInit();
            this.grpSelect.ResumeLayout(false);
            this.grpSelect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMenuName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMenuActionList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpMenuAction)).EndInit();
            this.grpMenuAction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeMenuList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpEdit)).EndInit();
            this.grpEdit.ResumeLayout(false);
            this.grpEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtActionCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsActionEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grpSelect;
        private System.Windows.Forms.ComboBox ddlSystem;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.Button btnSearch;
        private DevExpress.XtraEditors.TextEdit txtMenuName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.BindingSource bsMenuActionList;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colIndex;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colIsValid;
        private DevExpress.XtraEditors.GroupControl grpMenuAction;
        private DevExpress.XtraTreeList.TreeList treeMenuList;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colKeyID;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colMenuActiveName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colIsVisible;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colPath;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private DevExpress.XtraEditors.GroupControl grpEdit;
        private System.Windows.Forms.ComboBox ddlParent;
        private System.Windows.Forms.Button btnSave;
        private DevExpress.XtraEditors.TextEdit txtPath;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.BindingSource bsActionEdit;
        private DevExpress.XtraEditors.TextEdit txtActionCode;
        private DevExpress.XtraEditors.LabelControl labelControl8;
    }
}