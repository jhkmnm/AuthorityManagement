namespace AuthorityManagement
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barMenu = new DevExpress.XtraBars.BarButtonItem();
            this.barRole = new DevExpress.XtraBars.BarButtonItem();
            this.barAction = new DevExpress.XtraBars.BarButtonItem();
            this.barUser = new DevExpress.XtraBars.BarButtonItem();
            this.barSystem = new DevExpress.XtraBars.BarButtonItem();
            this.ribAuthority = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribSystem = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.docMain = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabVMain = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabVMain)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.barMenu,
            this.barRole,
            this.barAction,
            this.barUser,
            this.barSystem});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 1;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribAuthority});
            this.ribbon.Size = new System.Drawing.Size(758, 120);
            this.ribbon.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // barMenu
            // 
            this.barMenu.Caption = "菜单管理";
            this.barMenu.Description = "Menu";
            this.barMenu.Glyph = global::AuthorityManagement.Properties.Resources.menu;
            this.barMenu.Id = 1;
            this.barMenu.LargeGlyph = global::AuthorityManagement.Properties.Resources.menu;
            this.barMenu.Name = "barMenu";
            this.barMenu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_ItemClick);
            // 
            // barRole
            // 
            this.barRole.Caption = "角色管理";
            this.barRole.Description = "Role";
            this.barRole.Glyph = ((System.Drawing.Image)(resources.GetObject("barRole.Glyph")));
            this.barRole.Id = 2;
            this.barRole.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barRole.LargeGlyph")));
            this.barRole.Name = "barRole";
            this.barRole.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_ItemClick);
            // 
            // barAction
            // 
            this.barAction.Caption = "功能管理";
            this.barAction.Glyph = ((System.Drawing.Image)(resources.GetObject("barAction.Glyph")));
            this.barAction.Id = 3;
            this.barAction.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barAction.LargeGlyph")));
            this.barAction.Name = "barAction";
            this.barAction.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_ItemClick);
            // 
            // barUser
            // 
            this.barUser.Caption = "用户管理";
            this.barUser.Description = "User";
            this.barUser.Glyph = ((System.Drawing.Image)(resources.GetObject("barUser.Glyph")));
            this.barUser.Id = 4;
            this.barUser.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barUser.LargeGlyph")));
            this.barUser.Name = "barUser";
            this.barUser.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_ItemClick);
            // 
            // barSystem
            // 
            this.barSystem.Caption = "系统类型";
            this.barSystem.Description = "System";
            this.barSystem.Glyph = ((System.Drawing.Image)(resources.GetObject("barSystem.Glyph")));
            this.barSystem.Id = 5;
            this.barSystem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barSystem.LargeGlyph")));
            this.barSystem.Name = "barSystem";
            this.barSystem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_ItemClick);
            // 
            // ribAuthority
            // 
            this.ribAuthority.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribSystem});
            this.ribAuthority.Name = "ribAuthority";
            this.ribAuthority.Text = "权限管理系统";
            // 
            // ribSystem
            // 
            this.ribSystem.ItemLinks.Add(this.barUser);
            this.ribSystem.ItemLinks.Add(this.barRole);
            this.ribSystem.ItemLinks.Add(this.barMenu);
            this.ribSystem.ItemLinks.Add(this.barAction);
            this.ribSystem.ItemLinks.Add(this.barSystem);
            this.ribSystem.Name = "ribSystem";
            this.ribSystem.Text = "权限管理";
            // 
            // docMain
            // 
            this.docMain.MdiParent = this;
            this.docMain.MenuManager = this.ribbon;
            this.docMain.View = this.tabVMain;
            this.docMain.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabVMain});
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 534);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "FormMain";
            this.Text = "深圳市仕瑞达自动化设备有限公司";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabVMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.BarButtonItem barMenu;
        private DevExpress.XtraBars.BarButtonItem barRole;
        private DevExpress.XtraBars.BarButtonItem barAction;
        private DevExpress.XtraBars.BarButtonItem barUser;
        private DevExpress.XtraBars.BarButtonItem barSystem;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribAuthority;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribSystem;
        private DevExpress.XtraBars.Docking2010.DocumentManager docMain;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabVMain;
    }
}