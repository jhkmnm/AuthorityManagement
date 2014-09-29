namespace AuthorityManagement
{
    partial class FormMenuManage
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
            this.bsMenuEdit = new System.Windows.Forms.BindingSource(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.bsMenuActionList = new System.Windows.Forms.BindingSource(this.components);
            this.treeMenuActionList = new DevExpress.XtraTreeList.TreeList();
            this.colName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colIndex = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colIsValid = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colPath = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.grpEditMenu = new DevExpress.XtraEditors.GroupControl();
            this.ddlSystemEdit = new System.Windows.Forms.ComboBox();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.ddlParent = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.chkIsValid = new DevExpress.XtraEditors.CheckEdit();
            this.txtMenuDescription = new DevExpress.XtraEditors.TextEdit();
            this.txtPath = new DevExpress.XtraEditors.TextEdit();
            this.txtIndex = new DevExpress.XtraEditors.TextEdit();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grpEditAction = new DevExpress.XtraEditors.GroupControl();
            this.ddlActionType = new System.Windows.Forms.ComboBox();
            this.bsActionEdit = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.txtActionCode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.ddlParentMenu = new System.Windows.Forms.ComboBox();
            this.btnSaveAction = new System.Windows.Forms.Button();
            this.txtActionPath = new DevExpress.XtraEditors.TextEdit();
            this.txtActionName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.ddlAddType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grpSelect)).BeginInit();
            this.grpSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMenuName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMenuEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMenuActionList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeMenuActionList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpEditMenu)).BeginInit();
            this.grpEditMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkIsValid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMenuDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIndex.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpEditAction)).BeginInit();
            this.grpEditAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsActionEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtActionCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtActionPath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtActionName.Properties)).BeginInit();
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
            this.grpSelect.TabIndex = 0;
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
            // bsMenuEdit
            // 
            this.bsMenuEdit.DataSource = typeof(Model.View.MenuActionVO);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Location = new System.Drawing.Point(532, 68);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "新建";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // bsMenuActionList
            // 
            this.bsMenuActionList.DataSource = typeof(Model.View.MenuActionVO);
            // 
            // treeMenuActionList
            // 
            this.treeMenuActionList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeMenuActionList.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colName,
            this.colIndex,
            this.colIsValid,
            this.colPath});
            this.treeMenuActionList.DataSource = this.bsMenuActionList;
            this.treeMenuActionList.Location = new System.Drawing.Point(2, 59);
            this.treeMenuActionList.Name = "treeMenuActionList";
            this.treeMenuActionList.Size = new System.Drawing.Size(433, 639);
            this.treeMenuActionList.TabIndex = 1;
            // 
            // colName
            // 
            this.colName.Caption = "显示名称";
            this.colName.FieldName = "MenuActionName";
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
            this.colIsValid.Caption = "显示";
            this.colIsValid.FieldName = "IsVisible";
            this.colIsValid.Name = "colIsValid";
            this.colIsValid.OptionsColumn.AllowEdit = false;
            this.colIsValid.Visible = true;
            this.colIsValid.VisibleIndex = 2;
            this.colIsValid.Width = 37;
            // 
            // colPath
            // 
            this.colPath.Caption = "访问路径";
            this.colPath.FieldName = "Path";
            this.colPath.Name = "colPath";
            this.colPath.OptionsColumn.AllowEdit = false;
            this.colPath.Visible = true;
            this.colPath.VisibleIndex = 3;
            this.colPath.Width = 234;
            // 
            // grpEditMenu
            // 
            this.grpEditMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpEditMenu.Controls.Add(this.ddlSystemEdit);
            this.grpEditMenu.Controls.Add(this.labelControl8);
            this.grpEditMenu.Controls.Add(this.ddlParent);
            this.grpEditMenu.Controls.Add(this.btnSave);
            this.grpEditMenu.Controls.Add(this.chkIsValid);
            this.grpEditMenu.Controls.Add(this.txtMenuDescription);
            this.grpEditMenu.Controls.Add(this.txtPath);
            this.grpEditMenu.Controls.Add(this.txtIndex);
            this.grpEditMenu.Controls.Add(this.txtName);
            this.grpEditMenu.Controls.Add(this.labelControl6);
            this.grpEditMenu.Controls.Add(this.labelControl5);
            this.grpEditMenu.Controls.Add(this.labelControl4);
            this.grpEditMenu.Controls.Add(this.labelControl3);
            this.grpEditMenu.Controls.Add(this.labelControl2);
            this.grpEditMenu.Location = new System.Drawing.Point(441, 114);
            this.grpEditMenu.Name = "grpEditMenu";
            this.grpEditMenu.Size = new System.Drawing.Size(524, 388);
            this.grpEditMenu.TabIndex = 2;
            this.grpEditMenu.Text = "编辑菜单";
            this.grpEditMenu.Visible = false;
            // 
            // ddlSystemEdit
            // 
            this.ddlSystemEdit.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsMenuEdit, "SystemID", true));
            this.ddlSystemEdit.DataSource = this.bsMenuEdit;
            this.ddlSystemEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlSystemEdit.FormattingEnabled = true;
            this.ddlSystemEdit.Location = new System.Drawing.Point(117, 29);
            this.ddlSystemEdit.Name = "ddlSystemEdit";
            this.ddlSystemEdit.Size = new System.Drawing.Size(327, 20);
            this.ddlSystemEdit.TabIndex = 13;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(22, 30);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(65, 14);
            this.labelControl8.TabIndex = 12;
            this.labelControl8.Text = "所属系统(*)";
            // 
            // ddlParent
            // 
            this.ddlParent.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsMenuEdit, "ParentMenuID", true));
            this.ddlParent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlParent.FormattingEnabled = true;
            this.ddlParent.Location = new System.Drawing.Point(117, 97);
            this.ddlParent.Name = "ddlParent";
            this.ddlParent.Size = new System.Drawing.Size(399, 20);
            this.ddlParent.TabIndex = 11;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Location = new System.Drawing.Point(441, 354);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chkIsValid
            // 
            this.chkIsValid.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsMenuEdit, "IsVisible", true));
            this.chkIsValid.Location = new System.Drawing.Point(20, 205);
            this.chkIsValid.Name = "chkIsValid";
            this.chkIsValid.Properties.Caption = "菜单可见";
            this.chkIsValid.Size = new System.Drawing.Size(75, 19);
            this.chkIsValid.TabIndex = 9;
            // 
            // txtMenuDescription
            // 
            this.txtMenuDescription.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsMenuEdit, "Description", true));
            this.txtMenuDescription.Location = new System.Drawing.Point(117, 239);
            this.txtMenuDescription.Name = "txtMenuDescription";
            this.txtMenuDescription.Properties.AutoHeight = false;
            this.txtMenuDescription.Size = new System.Drawing.Size(399, 102);
            this.txtMenuDescription.TabIndex = 8;
            // 
            // txtPath
            // 
            this.txtPath.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsMenuEdit, "Path", true));
            this.txtPath.Location = new System.Drawing.Point(117, 170);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(399, 20);
            this.txtPath.TabIndex = 7;
            // 
            // txtIndex
            // 
            this.txtIndex.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsMenuEdit, "VisibleIndex", true));
            this.txtIndex.Location = new System.Drawing.Point(117, 133);
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.Size = new System.Drawing.Size(145, 20);
            this.txtIndex.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsMenuEdit, "MenuActionName", true));
            this.txtName.Location = new System.Drawing.Point(117, 62);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(145, 20);
            this.txtName.TabIndex = 4;
            this.txtName.ToolTip = "名称不能为空";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(22, 245);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(48, 14);
            this.labelControl6.TabIndex = 4;
            this.labelControl6.Text = "菜单描述";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(22, 173);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(72, 14);
            this.labelControl5.TabIndex = 3;
            this.labelControl5.Text = "菜单访问路径";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(22, 139);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(24, 14);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "排序";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(22, 99);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(65, 14);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "上级菜单(*)";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(22, 65);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(65, 14);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "显示名称(*)";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Location = new System.Drawing.Point(663, 68);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // grpEditAction
            // 
            this.grpEditAction.Controls.Add(this.ddlActionType);
            this.grpEditAction.Controls.Add(this.labelControl13);
            this.grpEditAction.Controls.Add(this.txtActionCode);
            this.grpEditAction.Controls.Add(this.labelControl9);
            this.grpEditAction.Controls.Add(this.ddlParentMenu);
            this.grpEditAction.Controls.Add(this.btnSaveAction);
            this.grpEditAction.Controls.Add(this.txtActionPath);
            this.grpEditAction.Controls.Add(this.txtActionName);
            this.grpEditAction.Controls.Add(this.labelControl10);
            this.grpEditAction.Controls.Add(this.labelControl11);
            this.grpEditAction.Controls.Add(this.labelControl12);
            this.grpEditAction.Location = new System.Drawing.Point(441, 493);
            this.grpEditAction.Name = "grpEditAction";
            this.grpEditAction.Size = new System.Drawing.Size(524, 205);
            this.grpEditAction.TabIndex = 6;
            this.grpEditAction.Text = "编辑功能";
            this.grpEditAction.Visible = false;
            // 
            // ddlActionType
            // 
            this.ddlActionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlActionType.FormattingEnabled = true;
            this.ddlActionType.Location = new System.Drawing.Point(117, 120);
            this.ddlActionType.Name = "ddlActionType";
            this.ddlActionType.Size = new System.Drawing.Size(145, 20);
            this.ddlActionType.TabIndex = 16;
            // 
            // bsActionEdit
            // 
            this.bsActionEdit.DataSource = typeof(Model.View.ActionVO);
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(22, 125);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(48, 14);
            this.labelControl13.TabIndex = 14;
            this.labelControl13.Text = "功能类型";
            // 
            // txtActionCode
            // 
            this.txtActionCode.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsActionEdit, "ActionCode", true));
            this.txtActionCode.Location = new System.Drawing.Point(117, 93);
            this.txtActionCode.Name = "txtActionCode";
            this.txtActionCode.Size = new System.Drawing.Size(145, 20);
            this.txtActionCode.TabIndex = 13;
            this.txtActionCode.ToolTip = "编码不能为空";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(22, 96);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(65, 14);
            this.labelControl9.TabIndex = 12;
            this.labelControl9.Text = "功能编码(*)";
            // 
            // ddlParentMenu
            // 
            this.ddlParentMenu.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsActionEdit, "MenuID", true));
            this.ddlParentMenu.DataSource = this.bsActionEdit;
            this.ddlParentMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlParentMenu.FormattingEnabled = true;
            this.ddlParentMenu.Location = new System.Drawing.Point(117, 32);
            this.ddlParentMenu.Name = "ddlParentMenu";
            this.ddlParentMenu.Size = new System.Drawing.Size(399, 20);
            this.ddlParentMenu.TabIndex = 11;
            // 
            // btnSaveAction
            // 
            this.btnSaveAction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSaveAction.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveAction.Location = new System.Drawing.Point(441, 174);
            this.btnSaveAction.Name = "btnSaveAction";
            this.btnSaveAction.Size = new System.Drawing.Size(75, 23);
            this.btnSaveAction.TabIndex = 10;
            this.btnSaveAction.Text = "保存";
            this.btnSaveAction.UseVisualStyleBackColor = false;
            this.btnSaveAction.Click += new System.EventHandler(this.btnSaveAction_Click);
            // 
            // txtActionPath
            // 
            this.txtActionPath.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsActionEdit, "ActionPath", true));
            this.txtActionPath.Location = new System.Drawing.Point(117, 148);
            this.txtActionPath.Name = "txtActionPath";
            this.txtActionPath.Size = new System.Drawing.Size(399, 20);
            this.txtActionPath.TabIndex = 7;
            // 
            // txtActionName
            // 
            this.txtActionName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsActionEdit, "ActionName", true));
            this.txtActionName.Location = new System.Drawing.Point(117, 63);
            this.txtActionName.Name = "txtActionName";
            this.txtActionName.Size = new System.Drawing.Size(145, 20);
            this.txtActionName.TabIndex = 4;
            this.txtActionName.ToolTip = "名称不能为空";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(22, 151);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(48, 14);
            this.labelControl10.TabIndex = 3;
            this.labelControl10.Text = "访问路径";
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(22, 34);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(65, 14);
            this.labelControl11.TabIndex = 1;
            this.labelControl11.Text = "上级菜单(*)";
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(22, 66);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(65, 14);
            this.labelControl12.TabIndex = 0;
            this.labelControl12.Text = "显示名称(*)";
            // 
            // ddlAddType
            // 
            this.ddlAddType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ddlAddType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlAddType.FormattingEnabled = true;
            this.ddlAddType.Items.AddRange(new object[] {
            "菜单",
            "功能"});
            this.ddlAddType.Location = new System.Drawing.Point(441, 70);
            this.ddlAddType.Name = "ddlAddType";
            this.ddlAddType.Size = new System.Drawing.Size(71, 20);
            this.ddlAddType.TabIndex = 14;
            // 
            // FormMenuManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 702);
            this.Controls.Add(this.ddlAddType);
            this.Controls.Add(this.grpEditAction);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grpEditMenu);
            this.Controls.Add(this.treeMenuActionList);
            this.Controls.Add(this.grpSelect);
            this.Name = "FormMenuManage";
            this.Text = "菜单管理";
            ((System.ComponentModel.ISupportInitialize)(this.grpSelect)).EndInit();
            this.grpSelect.ResumeLayout(false);
            this.grpSelect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMenuName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMenuEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMenuActionList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeMenuActionList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpEditMenu)).EndInit();
            this.grpEditMenu.ResumeLayout(false);
            this.grpEditMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkIsValid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMenuDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIndex.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpEditAction)).EndInit();
            this.grpEditAction.ResumeLayout(false);
            this.grpEditAction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsActionEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtActionCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtActionPath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtActionName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        
        private System.Windows.Forms.BindingSource bsMenuActionList;        
        private System.Windows.Forms.BindingSource bsMenuEdit;    
        private DevExpress.XtraEditors.GroupControl grpSelect;
        private System.Windows.Forms.Button btnSearch;
        private DevExpress.XtraEditors.TextEdit txtMenuName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Button btnAdd;
        private DevExpress.XtraTreeList.TreeList treeMenuActionList;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colIndex;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colIsValid;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colPath;
        private DevExpress.XtraEditors.GroupControl grpEditMenu;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.Button btnSave;
        private DevExpress.XtraEditors.CheckEdit chkIsValid;
        private DevExpress.XtraEditors.TextEdit txtMenuDescription;
        private DevExpress.XtraEditors.TextEdit txtPath;
        private DevExpress.XtraEditors.TextEdit txtIndex;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox ddlParent;
        private System.Windows.Forms.ComboBox ddlSystem;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.ComboBox ddlSystemEdit;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.GroupControl grpEditAction;
        private DevExpress.XtraEditors.TextEdit txtActionCode;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private System.Windows.Forms.ComboBox ddlParentMenu;
        private System.Windows.Forms.Button btnSaveAction;
        private DevExpress.XtraEditors.TextEdit txtActionPath;
        private DevExpress.XtraEditors.TextEdit txtActionName;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private System.Windows.Forms.ComboBox ddlAddType;
        private System.Windows.Forms.BindingSource bsActionEdit;
        private System.Windows.Forms.ComboBox ddlActionType;
        private DevExpress.XtraEditors.LabelControl labelControl13;
    }
}