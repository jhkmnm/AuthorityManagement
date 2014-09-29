using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Model.View;
using Model.Condition;
using SRDFAA.Fram.Utilities;
using Model.Enum;

namespace AuthorityManagement
{
    public partial class FormMenuManage : Form
    {
        #region 变量
        DAL.Menu menudal = new DAL.Menu();
        DAL.Action actiondal = new DAL.Action();
        EditType _edittype;        
        #endregion

        #region 属性
        private MenuActionVO SelectedMenuAction
        {
            get { return bsMenuActionList.Current as MenuActionVO; }
        }

        public IList<MenuActionVO> MenuList
        {
            get
            {
                return bsMenuActionList.DataSource as IList<MenuActionVO>;
            }
            set
            {
                if (value == null)
                {
                    bsMenuActionList.Clear();
                }
                else
                {
                    bsMenuActionList.DataSource = value;
                    treeMenuActionList.RefreshDataSource();
                }
            }
        }

        public MenuActionVO MenuEdit
        {
            get
            {
                return bsMenuEdit.Current as MenuActionVO;
            }
            set
            {
                if (value == null)
                {
                    bsMenuEdit.Clear();
                }
                else
                {
                    bsMenuEdit.DataSource = value;
                }
            }
        }

        public ActionVO ActionEdit
        {
            get
            {
                return bsActionEdit.Current as ActionVO;
            }
            set
            {
                if (value == null)
                {
                    bsActionEdit.Clear();
                }
                else
                {
                    bsActionEdit.DataSource = value;
                }
            }
        } 
        #endregion

        public FormMenuManage()
        {
            InitializeComponent();
                        
            MenuEdit = new MenuActionVO() { Description = "" };
            ActionEdit = new ActionVO() { ActionPath = "", ActionName = "" };
            ddlAddType.SelectedIndex = 0;
            this.Load += FormModuleManage_Load;
        }

        #region 窗体事件
        void FormModuleManage_Load(object sender, EventArgs e)
        {
            InitSystemDLL();

            QueryMenuActionList();
            InitActionType();
            this.treeMenuActionList.FocusedNodeChanged += treeMenu_FocusedNodeChanged;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            QueryMenuActionList();
        }

        private void treeMenu_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            LoadInof();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _edittype = EditType.ADD;
            ClearValue();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Delete())
            {
                MsgTool.Show("删除成功");
                QueryMenuActionList();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Save())
            {
                QueryMenuActionList();
            }
        }

        void ddlParentMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            MenuActionVO menu = MenuList.SingleOrDefault(where => where.KeyID == Convert.ToInt32(ddlParentMenu.SelectedValue) && where.Type == 0);
            if (menu != null)
                txtActionPath.Text = menu.Path + "." + txtActionCode.Text;
        }

        void txtActionCode_TextChanged(object sender, EventArgs e)
        {
            MenuActionVO menu = MenuList.SingleOrDefault(where => where.KeyID == Convert.ToInt32(ddlParentMenu.SelectedValue) && where.Type == 0);
            if (menu != null)
            {
                txtActionPath.Text = menu.Path + "." + txtActionCode.Text;
            }
        }

        private void btnSaveAction_Click(object sender, EventArgs e)
        {
            if (Save())
            {
                QueryMenuActionList();
            }
        }
        #endregion

        #region 自定义方法
        #region 加载数据
        private void QueryMenuActionList()
        {
            CommonUtil.ExecAction(() => { MenuList = menudal.GetMenuActionList(Convert.ToInt32(ddlSystem.SelectedValue), txtMenuName.Text); });

            InitMenuDLL();
        }

        void InitMenuDLL()
        {
            var menulist = MenuList.Where(menu => menu.ParentID == 0).ToList();
            MenuActionVO first = new MenuActionVO();
            first.MenuActionName = "";
            first.KeyID = 0;
            menulist.Insert(0, first);
            ddlParent.DataSource = menulist.ToList();
            ddlParent.DisplayMember = "MenuActionName";
            ddlParent.ValueMember = "KeyID";
            ddlParent.SelectedIndex = 0;

            var actionmenulist = MenuList.Where(menu => menu.Type == 0 && menu.ParentID != 0).ToList();
            //MenuActionVO first = new MenuActionVO();
            //first.MenuActionName = "全部";
            //first.KeyID = 0;
            actionmenulist.Insert(0, first);
            ddlParentMenu.DataSource = actionmenulist.ToList();
            ddlParentMenu.DisplayMember = "MenuActionName";
            ddlParentMenu.ValueMember = "KeyID";
            ddlParentMenu.SelectedIndex = 0;
        }

        void InitSystemDLL()
        {
            var systemlist = new DAL.System().GetList();
            ddlSystem.DataSource = systemlist;
            ddlSystem.DisplayMember = "SystemName";
            ddlSystem.ValueMember = "SystemID";

            SystemVO[] systemvos = new SystemVO[systemlist.Count];
            systemlist.CopyTo(systemvos);
            ddlSystemEdit.DataSource = systemvos.ToList();
            ddlSystemEdit.DisplayMember = "SystemName";
            ddlSystemEdit.ValueMember = "SystemID";
        }

        void InitActionType()
        {
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[] { new DataColumn("Text"), new DataColumn("Value") });
            DataRow rowA = dt.NewRow();
            rowA["Text"] = "按钮";
            rowA["Value"] = "1";
            dt.Rows.Add(rowA);
            DataRow rowB = dt.NewRow();
            rowB["Text"] = "列";
            rowB["Value"] = "2";
            dt.Rows.Add(rowB);
            ddlActionType.DataSource = dt;
            ddlActionType.DisplayMember = "Text";
            ddlActionType.ValueMember = "Value";
        }

        private void LoadInof()
        {
            if (SelectedMenuAction.Type == 0)
            {
                grpEditAction.Visible = false;
                grpEditMenu.Visible = true;
                grpEditMenu.Location = new Point(ddlAddType.Location.X, ddlAddType.Location.Y + 44);
                LoadMenuInfo();
            }
            else
            {
                grpEditMenu.Visible = false;
                grpEditAction.Visible = true;
                grpEditAction.Location = new Point(ddlAddType.Location.X, ddlAddType.Location.Y + 44);
                LoadActionInfo();
            }
        }

        private void LoadMenuInfo()
        {
            ddlSystemEdit.SelectedValue = SelectedMenuAction.SystemID;
            txtName.Text = SelectedMenuAction.MenuActionName;
            ddlParent.SelectedValue = SelectedMenuAction.ParentMenuID;
            txtIndex.Text = SelectedMenuAction.VisibleIndex.ToString();
            txtPath.Text = SelectedMenuAction.Path;
            chkIsValid.Checked = SelectedMenuAction.IsVisible;
            txtMenuDescription.Text = SelectedMenuAction.Description;
        }

        private void LoadActionInfo()
        {
            txtActionName.Text = SelectedMenuAction.MenuActionName;
            ddlParentMenu.SelectedValue = SelectedMenuAction.ParentMenuID;
            txtActionCode.Text = SelectedMenuAction.ActionCode;
            txtActionPath.Text = SelectedMenuAction.Path;
            ddlActionType.SelectedValue = SelectedMenuAction.ActionType;

            ddlParentMenu.SelectedIndexChanged -= ddlParentMenu_SelectedIndexChanged;
            txtActionCode.TextChanged -= txtActionCode_TextChanged;

            ddlParentMenu.SelectedIndexChanged += ddlParentMenu_SelectedIndexChanged;
            txtActionCode.TextChanged += txtActionCode_TextChanged;
        }
        
        #endregion

        /// <summary>
        /// 保存前检查输入的值
        /// </summary>
        /// <returns></returns>
        private bool InputMenuVerifier()
        {
            bool pass = true;
            DataVerifier dv = new DataVerifier();
            foreach (var grpitem in grpEditMenu.Controls)
            {
                var itemtext = grpitem as DevExpress.XtraEditors.TextEdit;
                if (itemtext != null)
                {
                    if (!string.IsNullOrEmpty(itemtext.ToolTip))
                    {
                        dv.Check(string.IsNullOrEmpty(itemtext.Text), itemtext.ToolTip);
                        if (!dv.Pass)
                        {
                            pass = dv.Pass;
                            break;
                        }
                    }
                    else if (itemtext.Name == txtPath.Name)
                    {
                        if (Convert.ToInt32(ddlParent.SelectedValue) != 0)
                        {
                            dv.Check(string.IsNullOrEmpty(itemtext.Text), "子菜单必须要有访问路径");
                            if (!dv.Pass)
                            {
                                pass = dv.Pass;
                                break;
                            }
                        }
                    }
                }
            }
            dv.CustomShowMsgIfFailed(MsgTool.ShowMsg);

            return pass;
        }

        private bool InputActionVerifier()
        {
            bool pass = true;
            DataVerifier dv = new DataVerifier();

            dv.Check(ddlParentMenu.SelectedValue.ToString().ToInt32(0) == 0, "必须选择上级菜单");
            pass = dv.Pass;

            if (dv.Pass)
            {
                foreach (var grpitem in grpEditAction.Controls)
                {
                    var itemtext = grpitem as DevExpress.XtraEditors.TextEdit;
                    if (itemtext != null)
                    {
                        if (!string.IsNullOrEmpty(itemtext.ToolTip))
                        {
                            dv.Check(string.IsNullOrEmpty(itemtext.Text), itemtext.ToolTip);
                            if (!dv.Pass)
                            {
                                pass = dv.Pass;
                                break;
                            }
                        }
                    }
                }
            }
            dv.CustomShowMsgIfFailed(MsgTool.ShowMsg);

            return pass;
        }

        private void ClearValue()
        {
            if (ddlAddType.Text == "菜单")
            {
                grpEditAction.Visible = false;
                grpEditMenu.Visible = true;
                grpEditMenu.Location = new Point(ddlAddType.Location.X, ddlAddType.Location.Y + 44);
                ClearMenuValue();
            }
            else
            {
                grpEditMenu.Visible = false;
                grpEditAction.Visible = true;
                grpEditAction.Location = new Point(ddlAddType.Location.X, ddlAddType.Location.Y + 44);
                ClearActionValue();
            }
        }

        private void ClearMenuValue()
        {
            foreach (var grpitem in grpEditMenu.Controls)
            {
                if (grpitem is DevExpress.XtraEditors.TextEdit)
                {
                    ((DevExpress.XtraEditors.TextEdit)grpitem).Text = string.Empty;
                }
                else if (grpitem is DevExpress.XtraEditors.CheckEdit)
                {
                    ((DevExpress.XtraEditors.CheckEdit)grpitem).Checked = false;
                }
            }
        }

        private void ClearActionValue()
        {
            foreach (var grpitem in grpEditAction.Controls)
            {
                if (grpitem is DevExpress.XtraEditors.TextEdit)
                {
                    ((DevExpress.XtraEditors.TextEdit)grpitem).Text = string.Empty;
                }
            }

            ddlParentMenu.SelectedIndex = 0;

            ddlParentMenu.SelectedIndexChanged -= ddlParentMenu_SelectedIndexChanged;
            txtActionCode.TextChanged -= txtActionCode_TextChanged;

            ddlParentMenu.SelectedIndexChanged += ddlParentMenu_SelectedIndexChanged;
            txtActionCode.TextChanged += txtActionCode_TextChanged;
        }

        private bool Delete()
        {
            DataVerifier dv = new DataVerifier();
            int result = 0;
            if (SelectedMenuAction.Type == 0)
                result = menudal.Delete(SelectedMenuAction.KeyID);
            else if (SelectedMenuAction.Type == 1)
                result = actiondal.Delete(SelectedMenuAction.KeyID);

            dv.Check(result == 0, "删除0行,删除失败");

            dv.CustomShowMsgIfFailed(MsgTool.ShowMsg);

            return dv.Pass;
        }

        private bool Save()
        {
            bool result = false;

            if (grpEditMenu.Visible)
            {
                result = SaveMenu();
            }
            else if (grpEditAction.Visible)
            {
                result = SaveAction();
            }

            return result;
        }

        /// <summary>
        /// 保存菜单
        /// </summary>
        /// <returns></returns>
        private bool SaveMenu()
        {
            if (InputMenuVerifier())
            {
                MenuActionVO menu = new MenuActionVO();
                menu.SystemID = ddlSystemEdit.SelectedValue.ToString().ToInt32();
                menu.MenuActionName = txtName.Text;
                menu.ParentMenuID = ddlParent.SelectedValue.ToString().ToInt32();
                menu.VisibleIndex = txtIndex.Text.ToInt32();
                menu.Path = txtPath.Text;
                menu.IsVisible = chkIsValid.Checked;
                menu.Description = txtMenuDescription.Text;
                DataVerifier dv = new DataVerifier();
                int result = 0;
                if (_edittype != EditType.ADD)
                {
                    menu.KeyID = SelectedMenuAction.KeyID;
                }

                result = menudal.Save(menu, SRDFAA.Fram.SystemInfo.CurrentUser);

                dv.Check(result == -1, "存在相同的菜单名称,请确认");

                dv.CustomShowMsgIfFailed(MsgTool.ShowMsg);

                return dv.Pass;
            }

            return false;
        }

        private bool SaveAction()
        {
            if (InputActionVerifier())
            { 
                ActionVO action = new ActionVO();
                action.MenuID = ddlParentMenu.SelectedValue.ToString().ToInt32();
                action.ActionName = txtActionName.Text;
                action.ActionCode = txtActionCode.Text;
                action.ActionPath = txtActionPath.Text;
                action.ActionType = ddlActionType.SelectedValue.ToString().ToInt32();
                DataVerifier dv = new DataVerifier();
                int result = 0;
                if (_edittype != EditType.ADD)
                {
                    action.ActionID = SelectedMenuAction.KeyID;
                }

                result = actiondal.Save(action, SRDFAA.Fram.SystemInfo.CurrentUser);

                dv.Check(result == -1, "同一个菜单下存在相同的功能名称，请确认");

                dv.CustomShowMsgIfFailed(MsgTool.ShowMsg);

                return dv.Pass;
            }

            return false;
        }
        #endregion

        

    }
}
