using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Model.View;
using Model.Enum;
using SRDFAA.Fram.Utilities;

namespace AuthorityManagement
{
    public partial class FormRoleManage : Form
    {
        public FormRoleManage()
        {
            InitializeComponent();
        }

        #region 变量
        DAL.Role roledal = new DAL.Role();
        DAL.User userdal = new DAL.User();
        DAL.Menu menudal = new DAL.Menu();
        EditType edittype;
        #endregion

        #region 属性
        #region 角色管理
        /// <summary>
        /// 角色管理-角色列表
        /// </summary>
        private IList<RoleVO> RoleList
        {
            get
            {
                return bsRoleList.DataSource as IList<RoleVO>;
            }
            set
            {
                if (value == null)
                {
                    bsRoleList.Clear();
                }
                else
                {
                    bsRoleList.DataSource = value;
                    grdRoleList.RefreshDataSource();
                }
            }
        }

        /// <summary>
        /// 角色管理-选择的角色
        /// </summary>
        private RoleVO SelectedRole
        {
            get { return bsRoleList.Current as RoleVO; }
        }
        #endregion

        #region 分配用户
        /// <summary>
        /// 分配用户-角色列表
        /// </summary>
        private IList<RoleVO> UserRoleManage_RoleList
        {
            get
            {
                return bsUM_RoleList.DataSource as IList<RoleVO>;
            }
            set
            {
                if (value == null)
                {
                    bsUM_RoleList.Clear();
                }
                else
                {
                    bsUM_RoleList.DataSource = value;
                    grcRole.RefreshDataSource();
                }
            }
        }
        
        /// <summary>
        /// 分配用户-用户列表
        /// </summary>
        private IList<UserVO> UserRoleManage_UserList
        {
            get
            {
                return bsUM_UserList.DataSource as IList<UserVO>;
            }
            set
            {
                if (value == null)
                {
                    bsUM_UserList.Clear();
                }
                else
                {
                    bsUM_UserList.DataSource = value;
                    grcUserList.RefreshDataSource();
                }
            }
        }

        /// <summary>
        /// 分配用户-角色下的用户列表
        /// </summary>
        private IList<UserRole> UserRoleManage_UserRoleList
        {
            get
            {
                return bsUM_UserRole.DataSource as IList<UserRole>;
            }
            set
            {
                if (value == null)
                {
                    bsUM_UserRole.Clear();
                }
                else
                {
                    bsUM_UserRole.DataSource = value;                    
                }
            }
        }

        /// <summary>
        /// 分配用户-选择的用户
        /// </summary>
        private IList<UserVO> UserRoleManage_SelectedUser
        {
            get { return UserRoleManage_UserList.Where(where => where.IsSelected).ToList(); }
        }
        
        /// <summary>
        /// 分配用户-选择的角色
        /// </summary>
        private RoleVO UserRoleManage_SelectedRole
        {
            get { return bsUM_RoleList.Current as RoleVO; }
        }
        #endregion        

        #region 分配权限
        /// <summary>
        /// 权限配置-角色列表
        /// </summary>
        private IList<RoleVO> Authority_RoleList
        {
            get
            {
                return bsUA_RoleList.DataSource as IList<RoleVO>;
            }
            set
            {
                if (value == null)
                {
                    bsUA_RoleList.Clear();
                }
                else
                {
                    bsUA_RoleList.DataSource = value;
                    grcUARoleData.RefreshDataSource();
                }
            }
        }

        /// <summary>
        /// 权限配置-菜单和功能列表
        /// </summary>
        private IList<MenuActionVO> MenuActionList
        {
            get
            {
                return bsUA_MenuActionList.DataSource as IList<MenuActionVO>;
            }
            set
            {
                if (value == null)
                {
                    bsUA_MenuActionList.Clear();
                }
                else
                {
                    bsUA_MenuActionList.DataSource = value;
                    treeMenuList.RefreshDataSource();
                }
            }
        }

        /// <summary>
        /// 权限配置-角色对应的菜单和功能
        /// </summary>
        private IList<RoleMenuAction> RoleMenuActionList
        {
            get
            {
                return bsUA_RoleMenuAction.DataSource as IList<RoleMenuAction>;
            }
            set
            {
                if (value == null)
                {
                    bsUA_RoleMenuAction.Clear();
                }
                else
                {
                    bsUA_RoleMenuAction.DataSource = value;
                }
            }
        }

        /// <summary>
        /// 权限配置-选择的角色
        /// </summary>
        private RoleVO Authority_SelectedRole
        {
            get { return bsUA_RoleList.Current as RoleVO; }
        }

        /// <summary>
        /// 选择的菜单和功能
        /// </summary>
        private MenuActionVO SelectedMenuAction
        {
            get { return bsUA_MenuActionList.Current as MenuActionVO; }
        }
        #endregion
        #endregion

        #region 窗体事件
        private void FormRoleManage_Load(object sender, EventArgs e)
        {
            grdRoleList.SetStyle(GridHelper.GridStyle.List);
            grcRole.SetStyle(GridHelper.GridStyle.List);
            grcUserList.SetStyle(GridHelper.GridStyle.List);
            GridHelper.SetColumnEditable(colIsSelected_UserManage);

            CommonUtil.ExecAction(Query);
            grdVRoleList.RowClick += grdVRoleList_RowClick;
        }

        void grdVRoleList_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {            
            txtRoleID.Text = SelectedRole.RoleID.ToString();
            txtRoleName.Text = SelectedRole.RoleName;
            txtDescription.Text = SelectedRole.RoleDescription;
            chkIsValid.Checked = SelectedRole.IsValid;
        }        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtRoleID.Text = "";
            txtRoleName.Text = "";
            txtDescription.Text = "";
            chkIsValid.Checked = false;
            edittype = EditType.ADD;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Save())
            {
                MsgTool.Show("保存成功");
                CommonUtil.ExecAction(Query);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Delete())
            {
                MsgTool.Show("删除成功");
                CommonUtil.ExecAction(Query);
            }
        }

        private void xtcRole_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (e.Page.Name == xtpUser.Name)
            {
                if (UserRoleManage_UserList == null)
                {
                    CommonUtil.ExecAction(QueryUser, "正在查询角色、用户信息", "查询出错");
                    SelectedRoleOfUsers();
                }

                grvRole.FocusedRowChanged -= grvRole_FocusedRowChanged;
                grvRole.FocusedRowChanged += grvRole_FocusedRowChanged;
            }
            else if (e.Page.Name == xtpPopedom.Name)
            {
                if (MenuActionList == null)
                {
                    CommonUtil.ExecAction(Query_MenuAction, "正在查询系统中的菜单、功能列表", "查询出错");
                    SelectedRoleOfMenuAction();
                }

                grvUARoleData.FocusedRowChanged -= grvUARoleData_FocusedRowChanged;
                grvUARoleData.FocusedRowChanged += grvUARoleData_FocusedRowChanged;
            }
        }

        void grvRole_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            SelectedRoleOfUsers();
        }

        void grvUARoleData_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            SelectedRoleOfMenuAction();
        }

        private void btnSaveUserRole_Click(object sender, EventArgs e)
        {
            CommonUtil.ExecAction(SaveRoleOfUsers, "正在保存数据", "");
        }

        private void btnAuthoritySave_Click(object sender, EventArgs e)
        {
            CommonUtil.ExecAction(SaveAuthority, "正在保存数据", "");
        }

        /// <summary>
        /// 选择父节点时,自动将子节点选中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void treeMenuList_CellValueChanged(object sender, DevExpress.XtraTreeList.CellValueChangedEventArgs e)
        {
            if (e.Column.Name == colIsSelected.Name)
            {                
                if(SelectedMenuAction.ItemCount > 0)
                {
                    var childnodes = MenuActionList.Where(where => where.ParentMenuID == SelectedMenuAction.KeyID);
                    Array.ForEach(childnodes.ToArray(), t => t.IsSelected = SelectedMenuAction.IsSelected);
                }
            }
        }

        void treeMenuList_CellValueChanging(object sender, DevExpress.XtraTreeList.CellValueChangedEventArgs e)
        {
            if (e.Column.Name == colIsSelected.Name && e.Node.HasChildren)
            {
                object objCol = this.treeMenuList.Columns[colIsSelected.FieldName];

                for (int i = 0; i < e.Node.Nodes.Count; i++)
                {
                    e.Node.Nodes[i].SetValue(objCol, e.Value);
                }

                e.Node.SetValue(objCol, e.Value);
                treeMenuList.RefreshDataSource();
            }
        }
        #endregion

        #region 自定义方法
        #region 角色管理
        private void Query()
        {
            RoleList = roledal.GetRoleList(0, string.Empty, -1);
            UserRoleManage_RoleList = RoleList;
            Authority_RoleList = RoleList;
            edittype = EditType.EDIT;
        }

        private bool Save()
        {
            DataVerifier dv = new DataVerifier();            
            dv.Check(string.IsNullOrEmpty(txtRoleName.Text), "请输入角色名称");

            if(dv.Pass)
            {
                RoleVO role = new RoleVO();
                role.RoleName = txtRoleName.Text;
                role.RoleDescription = txtDescription.Text;
                role.IsValid = chkIsValid.Checked;
                int result = 0;

                if (edittype == EditType.ADD)
                {
                    result = roledal.RoleInsert(role, SRDFAA.Fram.SystemInfo.CurrentUser);
                }
                else if (edittype == EditType.EDIT)
                {
                    role.RoleID = Convert.ToInt32(txtRoleID.Text);
                    result = roledal.RoleUpdate(role, SRDFAA.Fram.SystemInfo.CurrentUser);
                }

                dv.Check(result == -1, "已经存在相同的有效的角色名称");
            }

            dv.CustomShowMsgIfFailed(MsgTool.ShowMsg);

            return dv.Pass;
        }

        private bool Delete()
        {
            DataVerifier dv = new DataVerifier();
            dv.Check(string.IsNullOrEmpty(txtRoleID.Text), "请选择要删除的角色");
            
            if (dv.Pass)
            {
                int result = roledal.RoleDelete(SelectedRole.RoleID);
                dv.Check(result == -1, "该角色下已经分配了用户，不允许删除");
            }
            dv.CustomShowMsgIfFailed(MsgTool.ShowMsg);

            return dv.Pass;
        }
        #endregion

        #region 分配用户
        private void QueryUser()
        {
            UserRoleManage_UserList = userdal.GetUsers();
            QueryUserRole();
        }

        private void QueryUserRole()
        {
            UserRoleManage_UserRoleList = userdal.GetUserRoles();
        }

        /// <summary>
        /// 将用户信息设置为未选择状态
        /// </summary>
        private void SetDefaultUserRole()
        {
            Array.ForEach(UserRoleManage_UserList.Where(where => where.IsSelected).ToArray(), t=> t.IsSelected = false);
        }

        /// <summary>
        /// 根据选择的角色，下属的用户将被选中
        /// </summary>
        private void SelectedRoleOfUsers()
        {
            SetDefaultUserRole();
            var userroles = UserRoleManage_UserRoleList.Where(where => where.RoleID == UserRoleManage_SelectedRole.RoleID);

            Array.ForEach(userroles.ToArray(), t=> UserRoleManage_UserList.SingleOrDefault(where=> where.UserID == t.UserID).IsSelected = true);
            grcUserList.RefreshDataSource();
        }

        private void SaveRoleOfUsers()
        {
            var users = UserRoleManage_UserList.Where(where => where.IsSelected);
            DataVerifier dv = new DataVerifier();
            //dv.Check(users == null || users.Count() == 0, "请选择要分配的用户");
            //if (dv.Pass)
            //{
                StringBuilder sbUserID = new StringBuilder(users.Count());
                Array.ForEach(users.ToArray(), t => sbUserID.AppendFormat("{0},", t.UserID.ToString()));
                userdal.SaveRoleOfUsers(sbUserID.ToString(), UserRoleManage_SelectedRole.RoleID, SRDFAA.Fram.SystemInfo.CurrentUser);
                QueryUserRole();
            //}

            //dv.CustomShowMsgIfFailed(MsgTool.ShowMsg);
        }
        #endregion        

        #region 分配权限
        /// <summary>
        /// 查询所有菜单及功能
        /// </summary>
        private void Query_MenuAction()
        {
            MenuActionList = menudal.GetMenuActionList(1);
            Query_RoleMenuAction();

            treeMenuList.CellValueChanging += treeMenuList_CellValueChanging;
            treeMenuList.CellValueChanging += treeMenuList_CellValueChanging;
        }

        private void Query_RoleMenuAction()
        {
            RoleMenuActionList = roledal.GetRoleMenuActionList(0);
        }

        /// <summary>
        /// 将菜单、功能信息设置为未选择状态
        /// </summary>
        private void SetDefaultMenuAction()
        {
            Array.ForEach(MenuActionList.Where(where => where.IsSelected).ToArray(), t => t.IsSelected = false);
        }

        private void SelectedRoleOfMenuAction()
        {
            SetDefaultMenuAction();
            var userroles = RoleMenuActionList.Where(where => where.RoleID == Authority_SelectedRole.RoleID);

            Array.ForEach(userroles.ToArray(), t => MenuActionList.SingleOrDefault(where => where.KeyID == t.KeyID && where.Type == t.Type).IsSelected = true);
            treeMenuList.RefreshDataSource();
        }

        private void SaveAuthority()
        {
            var menuaction = MenuActionList.Where(where => where.IsSelected);
            DataVerifier dv = new DataVerifier();
            //dv.Check(menuaction == null || menuaction.Count() == 0, "请选择要分配给角色的权限");
            //if (dv.Pass)
            //{
                StringBuilder sbUserID = new StringBuilder(menuaction.Count());
                Array.ForEach(menuaction.ToArray(), t => sbUserID.AppendFormat("{0},{1};", t.KeyID.ToString(), t.Type.ToString()));
                roledal.SaveRoleAuthority(sbUserID.ToString(), Authority_SelectedRole.RoleID, SRDFAA.Fram.SystemInfo.CurrentUser);
                Query_RoleMenuAction();
            //}

            //dv.CustomShowMsgIfFailed(MsgTool.ShowMsg);
        }

        #endregion        

        #endregion
    }
}
