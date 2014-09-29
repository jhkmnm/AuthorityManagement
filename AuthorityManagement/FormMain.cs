using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;

namespace AuthorityManagement
{
    public partial class FormMain : DevExpress.XtraEditors.XtraForm
    {
        FormUserManage user = null;
        FormMenuManage menu = null;
        FormSystemManage system = null;
        FormRoleManage role = null;

        public FormMain()
        {
            InitializeComponent();
            docMain.View.DocumentClosing += View_DocumentClosing;
            this.WindowState = FormWindowState.Maximized;
        }

        void View_DocumentClosing(object sender, DevExpress.XtraBars.Docking2010.Views.DocumentCancelEventArgs e)
        {
            switch (e.Document.Form.Name)
            {
                case "FormUserManage":
                    user = null;
                    break;
                case "FormMenuManage":
                    menu = null;
                    break;
                case "FormSystemManage":
                    system = null;
                    break;
                case "FormRoleManage":
                    role = null;
                    break;
            }
        }

        void bar_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form childForm = null;

            switch (e.Item.Description)
            {
                case "User":
                    if (user == null)
                        user = new FormUserManage();
                    childForm = user;
                    break;
                case "Menu":
                    if (menu == null)
                        menu = new FormMenuManage();
                    childForm = menu;
                    break;
                case "System":
                    if (system == null)
                        system = new FormSystemManage();
                    childForm = system;
                    break;
                case "Role":
                    if (role == null)
                        role = new FormRoleManage();
                    childForm = role;
                    break;
            }

            AddChildForm(childForm);
        }

        private void AddChildForm(Form childForm)
        {
            var doc = docMain.GetDocument(childForm);

            if (doc == null)
            {
                childForm.MdiParent = this;
                childForm.Show();
            }
            else
            {
                docMain.View.ActivateDocument(doc.Form);
            }
        }
    }
}